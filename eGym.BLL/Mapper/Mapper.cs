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
        CreateMap<UpdateAccountRequest, AccountDTO>();

        CreateMap<EmployeeDTO, Employee>();
        CreateMap<Employee, EmployeeDTO>();
        CreateMap<CreateEmployeeRequest, Employee>();
        CreateMap<UpdateAccountRequest, EmployeeDTO>();

        CreateMap<FeedbackDTO, Feedback>();
        CreateMap<Feedback, FeedbackDTO>();
        CreateMap<CreateFeedbackRequest, Feedback>();
        CreateMap<UpdateFeedbackRequest, FeedbackDTO>();

        CreateMap<DietDTO, Diet>();
        CreateMap<Diet, DietDTO>();
        CreateMap<CreateDietRequest, Diet>();
        CreateMap<UpdateDietRequest, DietDTO>();

        CreateMap<ReservationDTO, Reservation>();
        CreateMap<Reservation, ReservationDTO>();
        CreateMap<CreateReservationRequest, Reservation>();
        CreateMap<UpdateReservationRequest, ReservationDTO>();
    }
}