private bool IsRegistered()
{
    return true;
}

internal async Task Activate(string[] args)
{
    Console.WriteLine("License Activated");
    await Task.CompletedTask;
}

private async Task<Models.Shared.LicenseKeyInstallResult> Activate(string email, string key)
{
    await Task.CompletedTask;
    return new Models.Shared.LicenseKeyInstallResult
    {
        IsSuccess = true,
        Message = "Activation always succeeds (patched)"
    };
}

internal async Task Deactivate(string[] args)
{
    Console.WriteLine("License Deactivated");
    await Task.CompletedTask;
}

private async Task<bool> Deactivate(string email)
{
    await Task.CompletedTask;
    return true;
}
