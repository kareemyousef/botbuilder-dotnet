﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Microsoft.Bot.Builder.Adapters;
using Microsoft.Bot.Schema;

namespace Microsoft.Bot.Builder
{
    public class BotAssert
    {
        public static void ActivityNotNull(IActivity activity)
        {
            if (activity == null)
                throw new ArgumentNullException(nameof(activity));
        }
        public static void ContextNotNull(IBotContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context)); 
        }
        public static void ConversationReferenceNotNull(ConversationReference reference)
        {
            if (reference == null)
                throw new ArgumentNullException(nameof(reference));
        }

        //public static void AdapterNotNull(ActivityAdapterBase adapter)
        //{
        //    if (adapter == null)
        //        throw new ArgumentNullException(nameof(adapter)); 
        //}

        public static void ActivityListNotNull(IList<Activity> activityList)
        {
            if (activityList == null)
                throw new ArgumentNullException(nameof(activityList)); 
        }

        public static void ActivityListNotNull(IList<IActivity> activityList)
        {
            if (activityList == null)
                throw new ArgumentNullException(nameof(activityList));
        }

        public static void MiddlewareNotNull(Middleware.IMiddleware middleware)
        {
            if (middleware == null)
                throw new ArgumentNullException(nameof(middleware));
        }

        public static void MiddlewareNotNull(Middleware.IMiddleware[] middleware)
        {
            if (middleware == null)
                throw new ArgumentNullException(nameof(middleware));
        }
    }
}
