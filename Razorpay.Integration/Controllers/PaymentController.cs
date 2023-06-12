using Microsoft.AspNetCore.Mvc;
using Razorpay.Integration.Models;
using Razorpay.Integration;
public class PaymentController : Controller
{
    private readonly ILogger<PaymentController> _logger;
    private readonly IPaymentService _service;
    private IHttpContextAccessor _httpContextAccessor;
    private readonly AppDbContext _dbContext;
    public PaymentController(ILogger<PaymentController> logger, IPaymentService service, IHttpContextAccessor httpContextAccessor, AppDbContext dbContext)
    {
        _logger = logger;
        _service = service;
        _httpContextAccessor = httpContextAccessor;
        this._dbContext = dbContext;

    }
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> ProcessRequestOrder(PaymentRequest _paymentRequest, PaymentRequest res)
    {
        if (ModelState.IsValid)
        {
            _dbContext.PaymentRequestt.Add(res);
            _dbContext.SaveChanges();
        }
        MerchantOrder _marchantOrder = await _service.ProcessMerchantOrder(_paymentRequest);
        return View("Payment", _marchantOrder);
    }
    [HttpPost]
    public async Task<IActionResult> CompleteOrderProcess(MerchantOrder model)
    {
        string PaymentMessage = await _service.CompleteOrderProcess(_httpContextAccessor);
        if (PaymentMessage == "captured")
        {
            //var obj = new Paydata { status = "Paid",order_id="",payment_id="",signature="66" };
            //_dbContext.paydatas.Add(obj);
            //_dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
        else
        {
            return RedirectToAction("Payment");
        }
    }
    public IActionResult Success()
    {
        return View();
    }
    public IActionResult Failed()
    {
        return View();
    }
    [HttpPost]
    public IActionResult update(Paydata paydata)
    {
        if (ModelState.IsValid)
        {
            _dbContext.paydatas.Add(paydata);
            _dbContext.SaveChanges();
            
        }
        return Ok("Success Payement");

    }
    public IActionResult updatefail(Paydata paydata)
    {
        if (ModelState.IsValid)
        {
            _dbContext.paydatas.Add(paydata);
            _dbContext.SaveChanges();

        }
        return Ok("Payement Failed");
    }


}