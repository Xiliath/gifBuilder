using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using gimmegif.web.host.Models.HelloWorldViewModels;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using gimmegif.web.host.Data;
using Microsoft.EntityFrameworkCore;
using ImageMagick;

namespace gimmegif.web.host.Controllers
{
    public class HelloWorldController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly ApplicationDbContext _context;

        public byte[] gif { get; private set; }

        public HelloWorldController(IHostingEnvironment hostingEnvironment, ApplicationDbContext context)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: HelloWorld
        public async Task<IActionResult> Index(IndexViewModel model)
        {
            var settings = await _context.Settings.FirstAsync();
            var client = await _context.Client.FirstAsync();
            model.Delay = (model.Delay == 0) ? 10 : model.Delay;
            model.TextSize = (model.TextSize == 0) ? 48 : model.TextSize;

            model.Info = settings.InstaTags.Replace("[NAME]", client.Name);
            model.TheGif = string.Format("data:image/gif;base64,{0}", GetTheGif(model) ?? "");
            
            return View(model);
        }

        private string GetTheGif(IndexViewModel model)
        {
            if (model == null || model.TheImages == null || model.TheImages.Count == 0)
            {
                return null;
            }
            string imageBase64 = null;
            string webRootPath = _hostingEnvironment.WebRootPath;

            model.TheImages = OrderAndExtend(model.TheImages);

            using (MagickImageCollection frames = CreateFrameCollection(model))
            {
                // Save gif
                MemoryStream ms = new MemoryStream();
                frames.Write(ms, MagickFormat.Gif);
                imageBase64 = Convert.ToBase64String(ms.ToArray());
            }

            return imageBase64;
        }

        private List<IFormFile> OrderAndExtend(List<IFormFile> files)
        {
            var ordered = files.OrderBy(x => x.FileName).ToList();
            var count = ordered.Count() -2;
            for (int i = 0; i < count; count--)
            {
                ordered.Add(ordered[count]);
            }
            return ordered;
        }

        private MagickImageCollection CreateFrameCollection(IndexViewModel model)
        {
            string webRootPath = _hostingEnvironment.WebRootPath;

            MagickImageCollection collection = new MagickImageCollection();
            foreach (var file in model.TheImages)
            {
                var image = new MagickImage(file.OpenReadStream());
                image.AnimationDelay = model.Delay; //delay is 1000ms/1sec
                new Drawables()
                      // Draw text on the image
                      .FontPointSize(model.TextSize)
                      .Font("Arial")
                      .StrokeColor(new MagickColor("yellow"))
                      .FillColor(MagickColors.Orange)
                      .TextAlignment(TextAlignment.Left)
                      .Text(20, 20 + model.TextSize, "GIMMEGIF")
                      //Draw text on the image
                      .FontPointSize(model.TextSize)
                      .Font("Calibri")
                      .StrokeColor(MagickColors.Black)
                      .FillColor(MagickColors.White)
                      .TextAlignment(TextAlignment.Right)
                      .Text(image.Width - 20, image.Height - 20, model.Info)
                      .Draw(image);
                collection.Add(image);
            }

            // Optionally reduce colors
            QuantizeSettings settings = new QuantizeSettings();
            settings.Colors = 256;
            collection.Quantize(settings);
            collection.Optimize();
            return collection;
        }

        

        // GET: HelloWorld/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HelloWorld/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HelloWorld/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HelloWorld/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HelloWorld/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HelloWorld/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HelloWorld/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}