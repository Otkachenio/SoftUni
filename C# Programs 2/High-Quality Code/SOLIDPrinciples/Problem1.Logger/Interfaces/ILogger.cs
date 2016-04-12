﻿namespace Problem1.Logger.Interfaces
{
    public interface ILogger
    {
        void Info(string message);

        void Warning(string message);

        void Error(string message);
    }
}