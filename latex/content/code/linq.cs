using Microsoft.Linq;
using Microsoft.EntityFrameworkCore;

// query che ottiene il prodotto con chiave primaria uguale a 2
List<ProductDTO> products = _context.Products.ToList();
ProductDTO product = (from product in products
                        where product.ProductID == 2
                        select product).First();

// equivalente SQL
// SELECT * FROM Products WHERE Products.ProductID = 2 LIMIT 1;