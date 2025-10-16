using System;
using Application.Profiles.DTOs;
using Microsoft.AspNetCore.Http;
using CloudinaryDotNet.Actions;

namespace Application.Interfaces;

public interface IPhotoService
{
    Task<PhotoUploadResult?> UploadPhoto(IFormFile file);
    Task<DeletionResult> DeletePhoto(string publicId);
}
