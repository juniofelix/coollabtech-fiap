﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoollabTech.Domain.Core.Notifications;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CoollabTech.UI.Web.Controllers
{
    public class BaseController : Controller
    {
        private readonly DomainNotificationHandler _notifications;

        public BaseController(INotificationHandler<DomainNotification> notifications)
        {
            _notifications = (DomainNotificationHandler)notifications;
        }

        public bool IsValidOperation()
        {
            return (!_notifications.HasNotifications());
        }
    }
}