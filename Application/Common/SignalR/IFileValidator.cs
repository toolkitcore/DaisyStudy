﻿namespace DaisyStudy.Application.Common.SignalR;

public interface IFileValidator
{
    bool IsValid(IFormFile file);
}
