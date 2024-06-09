﻿using LojaSonhoDeCafe.Api.Banco;
using LojaSonhoDeCafe.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace LojaSonhoDeCafe.Api.Repositories.Produtos
{
    public class ProdutoRepositoryApi : IProdutoRepositoryApi
    {
        private readonly BancoDeDado _bancoDeDados;
        public ProdutoRepositoryApi(BancoDeDado bancoDeDados)
        {
            _bancoDeDados = bancoDeDados;
        }

        public async Task<Produto> ObterProdutoPorId(Guid Id)
        {
            var produto = await _bancoDeDados
                                .Produtos
                                .Include(a => a.Categoria)
                                .FirstOrDefaultAsync(x => x.Id == Id);

            if (produto == null)
            {
                return null!;
            }

            return produto;
        }

        public async Task<IEnumerable<Produto>> ObterTodosOsProdutos( )
        {
            var produtos = await _bancoDeDados
                                .Produtos
                                .Include(a => a.Categoria)
                                .AsNoTracking()
                                .ToListAsync();

            if (produtos.Count <= 0)
            {
                return Enumerable.Empty<Produto>();
            }

            return produtos;
        }

        public async Task<IEnumerable<Produto>> ObterTodosProdutosPorCategoria(int id)
        {
            return await _bancoDeDados.Produtos
                                      .Include(a => a.Categoria)
                                      .Where(x => x.CategoriaId == id)
                                      .AsNoTracking()
                                      .ToListAsync();

        }

        public async Task<IEnumerable<Categoria>> ObterCategorias( )
        {
            return await _bancoDeDados.Categorias
                                      .AsNoTracking()
                                      .ToListAsync();

        }

        public async Task<IEnumerable<Produto>> ObterProdutosFavoritos( )
        {
            return await _bancoDeDados.Produtos
                                      .AsQueryable()
                                      .Include(a => a.Categoria)
                                      .Where(x => x.IsFavorito == true)
                                      .AsNoTracking()
                                      .ToListAsync();
        }

        public async Task AdicionarNovoProduto(Produto produto)
        {
            await _bancoDeDados.Produtos.AddAsync(produto);
            await _bancoDeDados.SaveChangesAsync();
        }


        public async Task AdicionarEstoqueAoProduto(Guid Id, int Quantidade)
        {
            var produto = await ObterProdutoPorId(Id);

            if (produto != null && Quantidade > 0 && produto.QuantidadeEmEstoque == 0)
            {
                produto.QuantidadeEmEstoque = Quantidade;
                await _bancoDeDados.SaveChangesAsync();
            }

        }

        public async Task AtualizaProdutoFavorito(Produto produto)
        {
            var produtoBd = await _bancoDeDados.Produtos.SingleOrDefaultAsync(x => x.Id == produto.Id);
            if (produtoBd != null)
            {
                produtoBd.IsFavorito = produto.IsFavorito;
                await _bancoDeDados.SaveChangesAsync();
            }
        }


        public async Task ExcluirProduto(Guid Id)
        {
            var produtoExclusao = await ObterProdutoPorId(Id);
            if (produtoExclusao != null)
            {
                _bancoDeDados.Produtos.Remove(produtoExclusao);
                await _bancoDeDados.SaveChangesAsync();

            }
        }


        public async Task<bool> ProdutoIdJaExisteAsync(Guid produtoId)
        {
            return await _bancoDeDados.Produtos.AnyAsync(p => p.Id == produtoId);
        }

    }
}
