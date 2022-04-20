// Copyright 2021-2022 Woohyun Shin
// SPDX-License-Identifier: GPL-3.0-only

namespace Numouse {
    internal class Behavior {
        internal enum BehaviorType { LeftClick, RightClick, MiddleClick, ScrollUp, ScrollDown, MoveRelative, MoveAbsolute }
        internal BehaviorType type;
        internal int param1;
        internal int param2;

        internal Behavior(BehaviorType type, int param1, int param2) {
            this.type = type;
            this.param1 = param1;
            this.param2 = param2;
        }
    }
}
