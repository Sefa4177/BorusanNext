using Application.Services.ImageService;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Adapters.ImageService;
public class AWSImageServiceAdapter : ImageServiceBase
{
    public override Task DeleteAsync(string imageUrl)
    {
        throw new NotImplementedException();
    }

    public override Task<string> UploadAsync(IFormFile formFile)
    {
        throw new NotImplementedException();
    }
}
