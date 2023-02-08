using System;
using AutoMapper;
using Comex.Models;
using Comex.Web.Data.Dto;

namespace Comex.Comex.Web.Profile
{
    public class ProdutoProfile : ProdutoProfile
    {
        public ProdutoProfile()
        {
            CreateMap<CriarProdutoDto, Produto>();
            CreateMap<AtualizarProdutoDto, Produto>();
        }
    }
}