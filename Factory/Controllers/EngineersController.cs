using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using RestaurantsCuisines.Models;
using System.Collections.Generic;
using System.Linq;

namespace SillyFactory.Controllers
{
  public class EngineersController : Controllers
  {
    private readonly FactoryContext _db;

    public EngineersController(FactoryContext db)
    {
      _db = db;
    }
  }
}