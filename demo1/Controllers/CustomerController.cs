using AutoMapper;
using demo1.Data.Repositories;
using demo1.Dtos;
using demo1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace demo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomersController(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CustomerReadDto>> GetCustomers()
        {
            var customers = _customerRepository.Get();

            return Ok(_mapper.Map<IEnumerable<CustomerReadDto>>(customers));
        }

        [HttpGet("{id}")]
        public ActionResult<CustomerReadDto> GetCustomerById([FromRoute] int id)
        {
            var customer = _customerRepository.FindById(id);
            if (customer != null)
            {
                return Ok(_mapper.Map<CustomerReadDto>(customer));
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<CustomerReadDto> CreateCustomer([FromBody] CustomerCreateDto customerCreateDto)
        {
            var customer = _mapper.Map<Customer>(customerCreateDto);
            var createdCustomer = _customerRepository.Create(customer);

            return _mapper.Map<CustomerReadDto>(createdCustomer);
        }

        [HttpPut]
        public ActionResult<CustomerReadDto> UpdateCustomer([FromBody] CustomerUpdateDto customerUpdateDto)
        {
            var customer = _mapper.Map<Customer>(customerUpdateDto);
            var updatedCustomer = _customerRepository.Update(customer);

            return _mapper.Map<CustomerReadDto>(updatedCustomer);
        }

        [HttpDelete("{id}")]
        public ActionResult<CustomerReadDto> DeleteCustomer([FromRoute] int id)
        {
            _customerRepository.Remove(new Customer() { Id = id });

            return new OkResult();
        }
    }
}
