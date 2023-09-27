using DesignPattern.Decorator.DAL;
using DesignPattern.Decorator.DecoratorPattern2;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Decorator.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Message message)
        {
            //Message message = new();
            //message.MessageContent = "Bu bir Content mesajıdır";
            //message.MessageSender = "Admin IK";
            //message.MessageReceiver = "Herkes";
            //message.MessageSubject = "Deneme Yapıyoruz";
            CreateNewMessage createNewMessage = new();
            createNewMessage.SendMessage(message);
            return View();
        }
        [HttpGet]
        public IActionResult Index2()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index2(Message message) 
        {
            //Message message = new();
            //message.MessageContent = "Bu bir Subject şifreli mesajıdır";
            //message.MessageSender = "Team Lead";
            //message.MessageReceiver = "Herkes";
            //message.MessageSubject = "Merhaba";
            CreateNewMessage createNewMessage = new();
            EncryptoBySubjectDecorator encryptoBySubjectDecorator = new(createNewMessage);
            encryptoBySubjectDecorator.SendMessageByEncryptoSubject(message);
            return View();
        }
        [HttpGet]
        public IActionResult Index3()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index3(Message message)
        {
            CreateNewMessage createNewMessage = new();
            SubjectIDDecorator subjectIDDecorator = new(createNewMessage);
            subjectIDDecorator.SendMessageIDSubject(message);
            return View();
        }
    }
}
