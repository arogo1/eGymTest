using System;
using AutoMapper;
using eGym.BLL.Models;
using eGym.BLL.Models.Requests;
using eGym.Domain;

namespace eGym.BLL.Mapper;

public class Mapper : Profile
{
	public Mapper()
	{
        CreateMap<AccountDTO, Account>();
        CreateMap<Account, AccountDTO>();
        CreateMap<CreateAccountRequest, Account>();
    }
}

