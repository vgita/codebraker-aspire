﻿namespace Codebreaker.GameAPIs.Models.Exceptions;

public class CodebreakerExceptionCodes
{
    public const string InvalidGameType = nameof(InvalidGameType);
    public const string UnexpectedGameType = nameof(UnexpectedGameType);
    public const string GameNotFound = nameof(GameNotFound);
    public const string GameNotActive = nameof(GameNotActive);
    public const string GameUpdateFailed = nameof(GameUpdateFailed);
    public const string GameTypeCurrentlyNotAvailable = nameof(GameTypeCurrentlyNotAvailable);
}
