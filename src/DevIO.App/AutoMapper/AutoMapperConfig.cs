using AutoMapper;
using DevIO.App.ViewsModels;
using DevIO.Business.Models;

namespace DevIO.App.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            //transformar fornecedor => fornecedorViewModel
            //Com o .ReverseMap() eu estou dizendo para fazer o inverso tornando um tranformação de mão dupla
            // isso é possivel desde que não tenha nenhuma construtor parametrizado em alguma das classes
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }
    }
}
