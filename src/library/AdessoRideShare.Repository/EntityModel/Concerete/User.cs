using AdessoRideShare.Repository.EntityModel.Abstract;
using System.Collections.Generic;

namespace AdessoRideShare.Repository.EntityModel.Concerete
{
    public class User : BaseEntityModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
