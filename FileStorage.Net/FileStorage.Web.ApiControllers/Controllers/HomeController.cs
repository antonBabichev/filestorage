using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FileStorage.Web.ApiControllers.Models;
using FileStorage.Repository;
using Microsoft.AspNetCore.Cors;

namespace FileStorage.Web.ApiControllers.Controllers;

public class HomeController : ControllerBase
{
    private readonly IFileStorage _fileStorage;

    public HomeController(IFileStorage fileStorage)
    {
        _fileStorage = fileStorage;
    }

    public int? Index()
    {
        return _fileStorage.GetFolder("test")?.Id;
    }
}
