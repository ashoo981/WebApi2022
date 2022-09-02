using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data.DBContext;
using Microsoft.Extensions.Logging;
using App.Business.Services;
using App.Data.Entities;

namespace App.WebApi.Controllers
{

    [ApiController]
    [Route("[controller]/[action]")]
    public class CrmdbController : ControllerBase
    {
        private readonly ILogger<CrmdbController> _logger;
        private readonly BanksService _service;
        private readonly BankBrachService _servicebb;
        private readonly BankAccountService _serviceba;
        private readonly CustomerService _servicecus;
        private readonly CustomerAdressService _serviceca;

        public CrmdbController(ILogger<CrmdbController> logger, BanksService service, BankBrachService servicebb, BankAccountService serviceba, CustomerService servicecus, CustomerAdressService serviceca)
        {
            _logger = logger;
            _service = service;
            _servicebb = servicebb;
            _serviceba = serviceba;
            _servicecus = servicecus;
            _serviceca = serviceca;
        }

        [HttpGet]

        public async Task<IActionResult> BanksGetir()
        {
            var list = await _service.GetList();
            return Ok(list);
        }

        [HttpPost]

        public async Task<IActionResult> AddBank(Bank banks)
        {
            try
            {

                await _service.AddBank(banks);
                return Ok("");
            }
            catch (Exception)
            {
                return BadRequest();
            }



        }

        [HttpPost]
        public async Task<IActionResult> UpdateBank(Bank banks)
        {
            try
            {

                await _service.UpdateBank(banks);
                return Ok("");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteBank(Bank banks)
        {
            try
            {

                await _service.DeleteBank(banks);
                return Ok("");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]

        public async Task<IActionResult> BankGetById(string id)
        {
            var list = await _service.BankGetByID(id);
            return Ok(list);
        }

        [HttpGet]
        public async Task<IActionResult> BankBranchGetir()
        {
            var list = await _servicebb.GetList();
            return Ok(list);
        }

        [HttpPost]
        public async Task<IActionResult> AddBankBranch(BankBranch bankbranch)
        {
            try
            {

                await _servicebb.AddBankBranch(bankbranch);
                return Ok("");
            }
            catch (Exception)
            {
                return BadRequest();
            }



        }

        [HttpPost]
        public async Task<IActionResult> UpdateBankBranch(BankBranch bankbranch)
        {
            try
            {

                await _servicebb.UpdateBankBranch(bankbranch);
                return Ok("");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteBankBranch(BankBranch bankbranch)
        {
            try
            {

                await _servicebb.DeleteBankBranch(bankbranch);
                return Ok("");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]

        public async Task<IActionResult> BankBranchGetById(string id)
        {
            var list = await _servicebb.BankBranchGetById(id);
            return Ok(list);

        }


        [HttpGet]
        public async Task<IActionResult> BankAccountGetir()
        {
            var list = await _serviceba.GetList();
            return Ok(list);
        }

        [HttpPost]
        public async Task<IActionResult> AddBankAccount(BankAccount bankaccount)
        {
            try
            {

                await _serviceba.AddBankAccount(bankaccount);
                return Ok("");
            }
            catch (Exception)
            {
                return BadRequest();
            }



        }

        [HttpPost]
        public async Task<IActionResult> UpdateBankAccount(BankAccount bankaccount)
        {
            try
            {

                await _serviceba.UpdateBankAccount(bankaccount);
                return Ok("");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteBankAccount(BankAccount bankaccount)
        {
            try
            {

                await _serviceba.DeleteBankAccount(bankaccount);
                return Ok("");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]

        public async Task<IActionResult> BankAccountGetById(string id)
        {
            var list = await _serviceba.BankAccountGetById(id);
            return Ok(list);

        }

        [HttpGet]
        public async Task<IActionResult> CustomerGetir()
        {
            var list = await _servicecus.GetCusList();
            return Ok(list);


        }



        [HttpPost]
        public async Task<IActionResult> AddCustomer(Customer customer)
        {
            try
            {

                await _servicecus.AddCustomer(customer);
                return Ok("");
            }
            catch (Exception)
            {
                return BadRequest();
            }








        }

        [HttpPost]
        public async Task<IActionResult> UpdateCustomer(Customer customer)
        {
            try
            {
                await _servicecus.UpdateCustomer(customer);
                    return Ok("");

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpPost]

        public async Task<IActionResult> DeleteCustomer(Customer customer)
        {
            try
            {
                await _servicecus.DeleteCustomer(customer);
                return Ok("");

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpGet]

        public async Task<IActionResult> CustomerGetById(string id)
        {
            
                var record = await _servicecus.CustomerGetById(id);
            return  Ok (record);
            
        }


        [HttpGet]
        public async Task<IActionResult> CustomerAdressGetir()
        {
            var list = await _serviceca.GetCusAdresList();
            return Ok(list);
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomerAdress(CustomerAdress customeradress)
        {
            try
            {
                await _serviceca.AddCustomerAdress(customeradress);
                return Ok("");

            }
            catch (Exception e)
            {

                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCustomerAdress(CustomerAdress customeradress)
        {
            try
            {
                await _serviceca.UpdateCustomerAdress(customeradress);
                return Ok("");

            }
            catch (Exception)
            {

                return BadRequest();
            }
        
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCustomerAdress(CustomerAdress customeradress)
        {
            try
            {
                await _serviceca.DeleteCustomerAdress(customeradress);
                return Ok("");
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpGet]

        public async Task<IActionResult> CustomerAdresGetirGetById(string id)
        {
            var record = await _serviceca.CustomerAdressGetById(id);
            return Ok(record);
        }

    }
}
