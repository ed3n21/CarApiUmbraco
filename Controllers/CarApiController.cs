using CarApi.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using Umbraco.Web.WebApi;
using AutoMapper;
using System.Linq;
using CarApi.App_Start;

namespace CarApi.Controllers
{
    public class CarApiController : UmbracoApiController
    {
        IMapper _mapper;

        public CarApiController()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfile());
            }));
        }

        // api/carbrands
        [HttpGet]
        [Route("api/carbrands")]
        public JsonResult<IEnumerable<CarBrandViewModel>> CarBrands()
        {
            var carBrands = Umbraco.ContentAtXPath("//carBrand").Select(x => x as CarBrand);
            var carBrandsViewModels = _mapper.Map<IEnumerable<CarBrandViewModel>>(carBrands);

            return Json<IEnumerable<CarBrandViewModel>>(carBrandsViewModels);
        }

        // api/carbrands/1147
        [HttpGet]
        [Route("api/carbrands/{id}")]
        public JsonResult<CarBrandViewModel> CarBrands(int id)
        {
            var carBrand = Umbraco.Content(id) as CarBrand;
            var carBrandViewModel = _mapper.Map<CarBrandViewModel>(carBrand);

            return Json<CarBrandViewModel>(carBrandViewModel);
        }

        // api/carmodels
        [HttpGet]
        [Route("api/carmodels")]
        public JsonResult<IEnumerable<CarViewModel>> CarModels()
        {
            var carModels = Umbraco.ContentAtXPath("//carModel").Select(x => x as CarModel);
            var carViewModels = _mapper.Map<IEnumerable<CarViewModel>>(carModels);

            return Json<IEnumerable<CarViewModel>>(carViewModels);
        }

        // api/carmodels/1148
        [HttpGet]
        [Route("api/carmodels/{id}")]
        public JsonResult<CarViewModel> CarModels(int id)
        {
            var carModel = Umbraco.Content(id) as CarModel;
            var carViewModel = _mapper.Map<CarViewModel>(carModel);

            return Json<CarViewModel>(carViewModel);
        }

        // api/carbrands/1147/carmodels
        [HttpGet]
        [Route("api/carbrands/{id}/carmodels")]
        public JsonResult<IEnumerable<CarViewModel>> CarBrandModels(int id)
        {
            var carModels = Umbraco.Content(id).Children.Select(child => child as CarModel);
            var carViewModels = _mapper.Map<IEnumerable<CarViewModel>>(carModels);

            return Json<IEnumerable<CarViewModel>>(carViewModels);
        }
    }
}