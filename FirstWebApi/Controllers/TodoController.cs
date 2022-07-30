using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FirstWebApi.DataAccess;
using FirstWebApi.Models;

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TesterHubContext _context;

        public TodoController(TesterHubContext context)
        {
            _context = context;
        }

        // GET: api/Todo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Todo>>> GetTodo()
        {
          if (_context.Todo == null)
          {
              return NotFound();
          }
            return await _context.Todo.ToListAsync();
        }

        // GET: api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Todo>> GetTodo(long id)
        {
          if (_context.Todo == null)
          {
              return NotFound();
          }
            var todo = await _context.Todo.FindAsync(id);

            if (todo == null)
            {
                return NotFound();
            }

            return todo;
        }

        // PUT: api/Todo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodo(long id, Todo todo)
        {
            if (id != todo.Id)
            {
                return BadRequest();
            }

            _context.Entry(todo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Todo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Todo>> PostTodo(Todo todoItem)
        {
            if (_context.Todo == null)
            {
                return Problem("Entity set 'TesterHubContext.Todo'  is null.");
            }
            _context.Todo.Add(todoItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTodo), new { id = todoItem.Id }, todoItem);
        }

        // DELETE: api/Todo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodo(long id)
        {
            if (_context.Todo == null)
            {
                return NotFound();
            }
            var todo = await _context.Todo.FindAsync(id);
            if (todo == null)
            {
                return NotFound();
            }

            _context.Todo.Remove(todo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        /// <summary>
        /// Updates the status of a Todo Item
        /// </summary>
        /// <param name="id">TodoItem Id</param>
        /// <param name="status">Status enum value</param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}/updateStatus/{status}")]
        public async Task<IActionResult> UpdateTodoStatus(long id, TodoItemStatus status)
        {
            Todo todo = _context.Todo.Where(x => x.Id == id).Single();
            todo.Status = status;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TodoExists(long id)
        {
            return (_context.Todo?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
