using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Core.Events
{
    /// <summary>
    /// It contains message, is a abstract class, which use mediatR Librabry and generic response is boolean
    /// </summary>
   public abstract class Message: IRequest<bool>
    {
        /// <summary>
        /// THose who extends can retrieve it
        /// </summary>
        public string MessageType { get; protected set; } 

        /// <summary>
        /// Protected constructor
        /// </summary>
        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
