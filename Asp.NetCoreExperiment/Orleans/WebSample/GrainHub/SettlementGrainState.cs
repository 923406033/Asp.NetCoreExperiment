﻿using System;

namespace GrainHub
{
    [Serializable]
    public class SettlementGrainState
    {     
        /// <summary>
        /// 状态，默认值为0
        /// </summary>
        public int Status
        {
            get; set;
        } = 0;
    }
}
