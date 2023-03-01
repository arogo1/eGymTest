using System;
using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.BLL;

public interface IDietService
{
    public Task GetById(int id);
    public Task Delete(int id);
    public Task Create();
    public Task Update();
}

