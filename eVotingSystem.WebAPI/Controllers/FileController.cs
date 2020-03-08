﻿
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using Microsoft.AspNetCore.Mvc;

namespace eVotingSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : BaseController<
        File,
        FileDTO,
        FileSearchRequest,
        FileRequest,
        FileRequest
        >
    {
        public FileController(IFileService Service) :
            base(Service)
        {
        }
    }
}