﻿using API.LuizaLabs.Application.DTO.DTO;
using API.LuizaLabs.Domain.Models;
using System.Collections.Generic;

namespace API.LuizaLabs.Application.Interface
{
    public interface IApplicationServiceFavorite
    {
        IEnumerable<ProductDTO> GetByCliente(int ID_CLIENTE);

        IEnumerable<ProductDTO> GetByProduto(int ID_PRODUTO);

        Favorite GetByProdutoAndCliente(int ClienteID,int ProdutoID);

        IEnumerable<FavoriteDTO> GetAll();

        void Add(FavoriteDTO obj);

        void Update(FavoriteDTO obj);

        void Remove(FavoriteDTO obj);        

        void Dispose();


    }
}
