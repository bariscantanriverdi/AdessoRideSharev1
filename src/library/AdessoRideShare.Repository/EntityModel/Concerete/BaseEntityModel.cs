using AdessoRideShare.Repository.EntityModel.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdessoRideShare.Repository.EntityModel.Concerete
{
    public class BaseEntityModel : IBaseEntityModel
    {
        public int Id { get; set; }
    }
}
