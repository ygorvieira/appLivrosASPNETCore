using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaLivros.Models;
using LojaLivros.Respositories;
using Microsoft.AspNetCore.Mvc;

namespace LojaLivros.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IProdutoRepository produtoRepository;
        private readonly IPedidoRepository pedidoRepository;

        public PedidoController(IProdutoRepository produtoRepository, IPedidoRepository pedidoRepository)
        {
            this.produtoRepository = produtoRepository;
            this.pedidoRepository = pedidoRepository;
        }

        public IActionResult Carrossel()
        {
            return View(produtoRepository.GetProdutos());
        }

        public IActionResult Cadastro()
        {
            Pedido pedido = pedidoRepository.GetPedido();
            return View(pedido.Itens);
        }

        public IActionResult Carrinho(string codigo)
        {
            if (!string.IsNullOrEmpty(codigo))
            {
                pedidoRepository.AddItem(codigo);
            }

            Pedido pedido = pedidoRepository.GetPedido();
            return View(pedido.Itens);
        }

        public IActionResult Resumo()
        {
            Pedido pedido = pedidoRepository.GetPedido();
            return View(pedido);
        }
    }
}