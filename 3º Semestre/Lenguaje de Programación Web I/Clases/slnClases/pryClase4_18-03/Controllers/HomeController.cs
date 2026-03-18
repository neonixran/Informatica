using Microsoft.AspNetCore.Mvc;
using pryClase4_18_03.Models;
using System.Diagnostics;

namespace pryClase4_18_03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Ejemplo()
        {
            return View();
        }

        public void Nuevo()
        {

        }

        public IActionResult validardatos(string usuario, string contraseña)
        {
            if (usuario == null || contraseña == null)
            {
                ViewBag.respuesta = "Usuario o contraseña no pueden estar vacios";
                ViewBag.color = "red";
                ViewBag.imagen = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQP2zhdLdBsQm1XlJbIhf2ZK8VIw1oWPwNalQ&s";
            }
            else
            {
                ViewBag.respuesta = "Bienvenido, " + usuario;
                ViewBag.color = "green";
                ViewBag.imagen = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxISEhISEhIVEBAVEhUVFRIQFRIPFQ8QFRUXFhUVFRUYHSggGBolGxUVITEhJSkrLi4uFx8zODMtNygtLisBCgoKDg0OGhAQGy0dHSUtLS0tLS0tLS0tLS0tLS0tLS0rLS0tLS0tLS0tLS0tLS0tLS0tLS0tLTc3LS0rKystK//AABEIAOEA4QMBIgACEQEDEQH/xAAbAAABBQEBAAAAAAAAAAAAAAAEAAIDBQYBB//EADYQAAIBAwMDAgQFAgUFAAAAAAABAgMEEQUhMRJBUQZxEyJhgRQykaGxQlIjJHLB0RVikuHx/8QAGgEAAgMBAQAAAAAAAAAAAAAAAAQBAgMFBv/EACgRAAICAQQBBAICAwAAAAAAAAABAgMRBBIhMUETIjJhFEIVcQVRYv/aAAwDAQACEQMRAD8A9xOM6IAGs4dZ1EknEJiEAHDoyciCvdqKbbIyiVFsIcwS5v4QzlrYyuvep1HKgzHXut1an9TMJXJFmowWZM3t16rpp4UkB1fWEfKPO3JvdvI1/co9QLS1cF0a2/8AVs5bRexUXeu1J8vYqeo7ko7mzD89+EEyvX5YXp+uVKT+Vsqus7CRHqsPz3/o3Om+r5Z+Z5NTZa3Tnj5kn7nkUHvkJhcyW6eDSNxstbW+z2mnWT4ZJ1Hlum+p6kMJvKNhpfqKnUSy8M2hYpG8XGXKZpEzoLRuYy4YQmaZBrA4QhAQIQhAAhCEACEIQAIQhAA1nexxnQAacm8HW8FLrWoqMXh8FZPBYl1DUowT8mI1vXpSbS7kF9qsp5Sez+xQ1pCs7H0LXaxRW2A2vNt5b3B2xzZHLP2F3yc6dk5Pkdk40RyqJcsjq3ax8vJKi2WhROfSJulikwT8XLwiP8dLwi3psYehsDDqYBK9l2SOQvJeETsZT8KxFmpj41GA0bvOerbxjIRTqp8Mq4NGM6Jx7QXGZLRruLymBt7HYEJtFIylF8cGq0TXJRklJ7HoGm6gqi5X2PHITLzRNYlTeOxtC0fo1eeJnq6mOyUel6sqiT7FvCY5GWR3GeUTI6NTHElRCEIAEIQgARxnRABzAmdI5ywAAl/cdMX22bPO9av3UlhPMU+U+di69S6r1Nwg9lj5ovKe26Mw4Cts88IR1Ooz7Yg03gDrB9WJW31TCMFHLFIVym8IgnVS5YFVucprH3I6sskaNYwOvRo4Q5lyzufucYzrGuqjVIc4XQ5yGDXMZ8UvtKOQ7AkzkpjeonaRkmixzn4/YgyPgyjiGc9hVG5cVjnfuw+FaL4aZVD4ZTyjGUMi12kjPrhlvGRNSmAUa+dgukzHbycm2uVcsMv9G1J05fRv/wAUeh6Zd9UU87P9zyyiaX09qjg1CTzFtYbe0EbVT5wN6XU7fbI9DpyyPQHa1s4a3T7+QwcQ+xwhCAgQhCABCENyADih9U3kqdPMJYl1LOMN9LTLqctmecareSqzlKWG18qxtsmzOyWELam3ZD+wKUiNjmyaytnUlhcLd742yJpZZzIpyeECTptpvhLzlZ9jNXqlubzVrBYUY/lSM7Ws1wxpQ2nb01KrX2ZmCy/cbdWsov6Gg/BQW+DsqaezRPQ1gys6bIpQZqriyWMpAVSzT7EFlEz0uGC/E3Lu5scFLc0HGRZMo4j3UFCRCkWdjZt9i5XYRwi9ieMcFzS0xJJ4FOzXgyky6iVlGk28FjHTnhBdCzwG5wURPkoIWklL6ZLKFNhOUHWtFSwRKOTHUURtj9gdBB9JDriycMPs+PO2P+TkDHGDgTg4SaZsvSt5KUZKUs4cVFbZwkaWEjzOzunTkpx/MuM7noNtX6op53aT/VDdUsrB0dLbujt8lgjpDCsvJKmajR0QhAAiKpNLnYkZnfU2o/Di0ucASRep9Sh8N01L5209s8J+TG1JA9S8c3lsa6gpbLLOPqZ7pkzkXWk0FFKXdrf6blDQi3JYWd/2yayjFJfQtTEZ0FW57mN1KqkvsZC9u0mXWuXaMlfzW7N2deMSV3Z2N3Ezs67ySwoVJdnuVaNcGkV3FoHq10V1DT622zCo6XV/tZXAI5OWSq1GyyuruXkbOS5WAe5pbF0gaMtRo74wabS7fuV1K1TkjZ6LZLp+pOSMAU0RNpbsvrmwWMt4RU1qC45RjN4Mbr4VLnsgrXiey4Bp3O3kM+DFEc7ePgx3cnG/Knv3lctUiy10vUo7bgFzpUZbx2YJCnKkzWLydiq1Wxyj0KpCNSnnvFPGHtvgqGhug3yez4C7yliTeMKTbj9UVmvJztfV+6BlI0/pa7j0um387llLfhRWTNKKLDSLiNOqpSeElLf6tEVvDEaJ7Zo2MpPO3ktqK2RQ2VwpyWC/hwOHZyOEIQANqcGZ9U2fVFs1ADqNNOEs+CH0GeDx+eza+o+mzt/jrlj+5/yNpCMuzhTfLLXSqOWn7l1d1OleCq06p0xX3Ga7qC6dhuvhHd0sFGCwVGt3afczdeo5E95U6myS1tcfMyzY9FE9lYLGWslrSj4RUV9VjTWFu/BS3nqGo08JwAiUsG6jLH9SXuw6xvop4lKLPH7DXpfGTqybp533L31Fq9BqLtpvqxus53JwV3HqFzaRqLMcfYzOq0OnK7lF6P8AV04y6areON9zQ6lcqouqPcC6KKjT+ZG60qklBSeMfoYunHcvKd4+jpzhNb/UylJIxvujVHLDtRvVJ4W0V4eUyjur6K43B7y7aWEVs2933F28nnrLJWSyy0o3PVwsild42KuzvXDOFk5cV28vDz4Xb6kJFYwc3tRcULqLfP2YbcW0Zo86pXFVVd23ubvRbtyWHubwjg9BpqPShgHoNwl9zS566al/an+5R3Md2WdhXSpyi/BMlwV1UE4MdFja0h0Ae8lhGC7PPL5Gv9OV05bGxied+jOr4m56LEdT4O7H4o6IQiSRFdrCfw5Y8FiRV4JxaYEPpni1b80vd/yOok2q0sVJ4/uf8sHoyEZfI4c+y13jBfcoL6cpPHY0fNNe7/YqriGGNQ6PRUcQRSK2lnPITdt9DxyHxiMlArZJItdqI1R57MxCwbfxJc8rDe2V3J56bCrz+bGE89i2q0CCVFmG9nDlqZynvMvf+lJQe26+hy20XoTck/3NVLrxhNnI20prDGYyyjs0XRsjnyYinbTcvlTRt9FU+j5i4stEhFZcSK4kuFwROeEF+oVUc+QZImzsRdYlMWctzycS26VjzIHuKTZCoeUWdKOQmnYOa244ISbKQg7JbUU34aPlJjK1SnBNL83GQqpos03yRf8ARZdzZQwd7T6SNa+yrtbbqlnBqNOtulfUGtLHo5DuouhxLBJOjkVKi915O05ZDKS2bJa4F9R8GMgsICu02w6Lzn3IpwFV2eZS9xr/AEradO7XY1iKnSKPTFfYtkPLo7sV7UdEIRJIhsxw2YEM8r1elmc3/wB0v5ZVQiXmp/mqf6pfyymEZdnDn8iypP8Awl7v+QGvHIZbPqgorlZf2B5rcar+J39PLNaBYQwN6QiSIwnBSJvpVqImjnSh80MFWsM4c4ODwznw0E2eE9+CDI3rBPBNdsoPMQ3Ubz+lcbcFTKQ+rIhBvJWyyVjyzojmSOpUwQlkIQc3hE9Oqky8trxYSRlevLyFU7hoahDadvS6dVR+zSVK5BOoV1O6zyTdZdodTJkxYIHJklu8sEG4IpIMX5Je3+6G06RJV2TXlET+IrqJexg1NkrQymPYmuzzy+R6Xar5V7IJRBbflXsv4CB87kekIQhASIbNDhAB536isXSnJN56sy22xmTM2b31lZSeKm3Skovzlvb+TEVKeGJ2LDOLqIbZsm0+soSy98rH6ljOjF7lPwWtKpmKZpVLwP6C39WCXKRX1GE3dZJ77Ak6ifc3OoNcxjmMkNM7IZQvqKFbH7H9QsDEOyKtY7OJOEoPEhkyIlkyNgll4IhBzlhDJg8kF9JHOmOQgoo7mnoVUfsEJIMbNjoFmMonjLBPSqtg+CSiBYNUyag9wLDCaE8cgUbLmhXIryspPC7Aka/g4pZfuY2y4wc3XWcbUG0gmytXVmoJpNpvLz2QNSReenLCcpqosdKzF85y12Ma1lnOpjumkbWhwvYmIKCaW5Oh07SWBCEIAEIQgAD1KzjVg4yzjZ7bcHmF7Sak8cZ/g9aaMn6u02KXxU8PKjhJJd9/cytjlZE9VU5LKMO89ya0r4byKrDcjlEWjJp5OfXNwluRFqCyyr62mW6hnZ/8h9HRFJbobjJNHdptVkcopaS6lwPlSL//AKaoLGCquaeCxumAOBzBNJETKShuMbtOrVyQXE8LP0MrX1mopNNbJ9jWTp5+oDc6MpZeAhBRCnTRqX2E6ZcKpBSBtY1B08KKHWNCVOPSyC5pdct0XNwSznOb6pfoWkIElpZpdgqcNiCyB4QyF0qAylAsaESSASpDCyAyqt/+jU07D4iwBXunwpvCw5d1vtsVbwjG21Vxyysoxwg2iiFUmFUFgUlLLOBbY5y3BVE9E0eyjSppRz82JPO+7SMz6SsVOTm/6XjGzTTXc26iMVRwsj2kq2+5nByFg6bDohCEACEIQAIHu7aNRYkk1zus7+Qg4wIazwea6zpcqU2t5R2+bGFlrhFa4HoerWsZ5Uo58fR4wmYG+oOnJxe+O+HhitkMco5eo07g9y6IEsGl0K8g49Mmk1hZk/zcmYTCrd4M4yw8mdV7reUaDVF44fjwZ+4oMLeptJqWZ8Y4WEiXrTWdt1xlZGozTOvTqIzM9UovwRukXVekA1aZcdQA4EkZ45HypENVAWxkhuKiZFRxkfOA2nDDAnaGJHWhtPcIhRAjBHSpFjQpkNOCXOP4HSutsJY+pSViQpdqIV9llTu4wjtht7bPeOVyAVsttt5flkVNkjYtOeTi33u158EDQZp9m6kkknjOG+VHbuDU6bk8L/4abSaSglFJZ7td2WhDPZbT6d2PL6NFo1tGCSSS2WcLGWtslqgGxQcxpLCOthJYR0QhEgIQhAAhCEACOM6cYAA3y2ZjtYoqTw+2Wvfc2d5wYbWrjEgwn2S4prDKWpRced/YfCRLGqpbHJ22MOP3yKzqx0cy/SOPMehgovpeVyhIbKeDLlCibix8byWfm3X0HqalxsAyqoY6pdWNDdesnH7DK1MDqUmRyrETuDT1hv8Ak8fqSumccCP42RfHI9YP5P8A5CIbE3xvH7gMbhE6roo7Gxe3X2T64JZNvklhAHjXQRTqZ2RTsSk3JksYj40nLZFnpul9Scp/kxth4eR9TEY9Me3GeTWNY1TpXLmXQPb0OhfXuW2lr5ikdwXWgTTYwlg6UYqKwjWWscBLZDS7EyRYlnRCEBAhCEACEIQAIaxwPc11BZYIAXUpYizzL1Bcvr+5pvUnqSKTS8Hnl9fupJv69wZYsbG4XVuXNGsmYt1Wt8l3pt3lLu8kAzYULeM4dL2yuVjJValpMov5E5xxnLxz4C7C54LJzjJ9PUurGenKzj2KSgmYz08JrkxNxRlF4ksArRq76lFya2cl22zjzgpK8Ic5jjjOVyuV7mLqfgXegfhlZKORjgHfDj2kpecNPHuDuUXnElJrnDTx+hX05GX4VpCng4xsqyzjKz4ysjoyWcPCfOG1x5D02H4NolAnijtPpePmi/Zp/wC4XGMU0m0n4bWf0LeizWP+Pl5ZHQtnJpeTS6RZJc7+6QNZW+C6owwbRrSG4aWECa4rKMccGfr192H39wtzK6ndtZwXNOiW4u8PYsdB1LE0YyVy292E2Ny4yTyBB7dp9dNIPTMT6W1iMljq32NfSq5JICBHEzoECEIQAIQycisvNSUM7gTgsKtVLOTI+ptcSTSBtW9SYTxyYLUr+U5N5DJJDqF25yzkHpo4ienEgnBBUiTWFZpodOgx1tQafAAaGyuftgwUfUEFefj8y+LG86EuiTh+C6HSfz4xy8/c2NKmmpRl+WUXF4ynhpp8fRnZULdW34T4f+XcelwzLOM5z1ZznOHnPYAH6dOMtXu23tK0oNfVZ5/TczWj6XSr2l/KdNVFC7u5wbzt8q3X6F1d6RbXHR1QacIKClGdSE/hr+lyTzJe5cWVpSp0HbwpqFJxlFxi3upJp785eeQJR59Ws40dIhVpR+HUqxpKrUjnLi57thGv6VStXaTtoqE5V4Q+Rt/FptPq6l3N9bafbq3Vt0J0FDo6J5knHw2937gFn6Rs6MlUpwfXH8rqTnV6P9Kk2kBdHmOsUl8a9/wsv40IxrOXSqEmtm/oX8LbN/RhN9X+RkpN8S3wzWVPTtFutmOVXeauW31bYWPB239M26kpNNuNF0U3Obfwn2bzvzyBJlPT+jUq1w7ilSjChRco03FNfHrLZy53iuwtB0ahc2dxc3C6q/VWcqkm+qi4ZcceMYNXY+kLKjKE4RqRcJKUUq1VpNPPHVgbfelrGpOU5UmnJ5koTqU4VHzmUFLDAqFehriU7G2nUb63DdvlpNqL/RGi/EvD9ijlXUIqMUowikoxjsoxXCSOQ1Ts0GSNw3ULh7mZ1Cq28di9vailwUd7DcCoJCI9nYRydlAADtD1D4U0+zPS9D1hTxh5PH3lFxoeqSpSW+wAe10KuQjJj9J9Qxljyaa2r9RJXAWIaICBlbgyutcM6IhkmC1buZ+fIhASdiGUxCAsEokiIQFUEg1fkQgJCdP5LIQgAcuw8QgNEPiNqCEAeSMbIQisuyGDXnBXVBCJRkSRAb4QiQ8EFqOfLEIC0QStyOpdvcQgA1ehco9I0v8AKvZCEBBZCEIkg//Z";
            }

            return View("Ejemplo");
        }

        public IActionResult Agregar()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
