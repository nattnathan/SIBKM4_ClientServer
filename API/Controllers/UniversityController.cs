using API.Models;
using API.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UniversityController : ControllerBase
{
    private readonly IUniversityRepository _universityRepository;
    public UniversityController(IUniversityRepository universityRepository)
    {
        _universityRepository = universityRepository;
    }

    [HttpGet]
    public ActionResult GetAll()
    {
        var universities = _universityRepository.GetAll();
        return Ok(universities);
    }

    [HttpGet("{id}")]
    public ActionResult GetById(int id)
    {
        var university = _universityRepository.GetById(id);
        if (university == null)
            return NotFound();
        return Ok(university);
    }

    [HttpPost]
    public ActionResult Insert(University university)
    {
        if (university.Name == "" || university.Name.ToLower() == "string") {
            return BadRequest("Value Cannot be Null or Default");
        }

        var insert = _universityRepository.Insert(university);
        if (insert > 0)
            return Ok("Insert Success");
        return BadRequest("Insert Failed");
    }

    [HttpPut]
    public ActionResult Update(University university)
    {
        if (university.Name == "" || university.Name.ToLower() == "string") {
            return BadRequest("Value Cannot be Null or Default");
        }

        var update = _universityRepository.Update(university);
        if (update > 0)
            return Ok("Update Success");
        return BadRequest("Update Failed");
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var delete = _universityRepository.Delete(id);
        if (delete > 0)
            return Ok("Delete Success");
        return BadRequest("Delete Failed");
    }
}
