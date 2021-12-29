/*
 *  Numouse
 *  Copyright (C) 2021 Woohyun Shin
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */

using static Numouse.NativeFunctions;

namespace Numouse {
    internal static class MouseActions {
        internal static void SimulateClick() {
            INPUT[] input = new[] {
                new INPUT {
                    type = (uint)INPUT_TYPE.INPUT_MOUSE,
                    U = new InputUnion {
                        mi = new MOUSEINPUT {
                            dwFlags = MOUSEEVENTF.LEFTDOWN,
                            dwExtraInfo = GetMessageExtraInfo()
                        }
                    }
                },
                new INPUT {
                    type = (uint)INPUT_TYPE.INPUT_MOUSE,
                    U = new InputUnion {
                        mi = new MOUSEINPUT {
                            dwFlags = MOUSEEVENTF.LEFTUP,
                            dwExtraInfo = GetMessageExtraInfo()
                        }
                    }
                }
            };
            SendInput((uint)input.Length, input, INPUT.Size);
        }

        internal static void SimulateRightClick() {
            INPUT[] input = new[] {
                new INPUT {
                    type = (uint)INPUT_TYPE.INPUT_MOUSE,
                    U = new InputUnion {
                        mi = new MOUSEINPUT {
                            dwFlags = MOUSEEVENTF.RIGHTDOWN,
                            dwExtraInfo = GetMessageExtraInfo()
                        }
                    }
                },
                new INPUT {
                    type = (uint)INPUT_TYPE.INPUT_MOUSE,
                    U = new InputUnion {
                        mi = new MOUSEINPUT {
                            dwFlags = MOUSEEVENTF.RIGHTUP,
                            dwExtraInfo = GetMessageExtraInfo()
                        }
                    }
                }
            };
            SendInput((uint)input.Length, input, INPUT.Size);
        }

        internal static void SimulateMiddleClick() {
            INPUT[] input = new[] {
                new INPUT {
                    type = (uint)INPUT_TYPE.INPUT_MOUSE,
                    U = new InputUnion {
                        mi = new MOUSEINPUT {
                            dwFlags = MOUSEEVENTF.MIDDLEDOWN,
                            dwExtraInfo = GetMessageExtraInfo()
                        }
                    }
                },
                new INPUT {
                    type = (uint)INPUT_TYPE.INPUT_MOUSE,
                    U = new InputUnion {
                        mi = new MOUSEINPUT {
                            dwFlags = MOUSEEVENTF.MIDDLEUP,
                            dwExtraInfo = GetMessageExtraInfo()
                        }
                    }
                }
            };
            SendInput((uint)input.Length, input, INPUT.Size);
        }

        internal static void SimulateMovementRelative(int dx, int dy) {
            INPUT[] input = new[] {
                new INPUT {
                    type = (uint)INPUT_TYPE.INPUT_MOUSE,
                    U = new InputUnion {
                        mi = new MOUSEINPUT {
                            dx = dx,
                            dy = dy,
                            dwFlags = MOUSEEVENTF.MOVE,
                            dwExtraInfo = GetMessageExtraInfo()
                        }
                    }
                }
            };
            SendInput((uint)input.Length, input, INPUT.Size);
        }

        internal static void SimulateMovementAbsolute(int x, int y) {
            INPUT[] input = new[] {
                new INPUT {
                    type = (uint)INPUT_TYPE.INPUT_MOUSE,
                    U = new InputUnion {
                        mi = new MOUSEINPUT {
                            dx = x,
                            dy = y,
                            dwFlags = MOUSEEVENTF.MOVE | MOUSEEVENTF.ABSOLUTE | MOUSEEVENTF.VIRTUALDESK,
                            dwExtraInfo = GetMessageExtraInfo()
                        }
                    }
                }
            };
            SendInput((uint)input.Length, input, INPUT.Size);
        }

        internal static void SimulateWheelUp(int amount) {
            INPUT[] input = new[] {
                new INPUT {
                    type = (uint)INPUT_TYPE.INPUT_MOUSE,
                    U = new InputUnion {
                        mi = new MOUSEINPUT {
                            dwFlags = MOUSEEVENTF.WHEEL,
                            mouseData = SystemInformation.MouseWheelScrollDelta * amount,
                            dwExtraInfo = GetMessageExtraInfo()
                        }
                    }
                }
            };
            SendInput((uint)input.Length, input, INPUT.Size);
        }

        internal static void SimulateWheelDown(int amount) {
            INPUT[] input = new[] {
                new INPUT {
                    type = (uint)INPUT_TYPE.INPUT_MOUSE,
                    U = new InputUnion {
                        mi = new MOUSEINPUT {
                            dwFlags = MOUSEEVENTF.WHEEL,
                            mouseData = -SystemInformation.MouseWheelScrollDelta * amount,
                            dwExtraInfo = GetMessageExtraInfo()
                        }
                    }
                }
            };
            SendInput((uint)input.Length, input, INPUT.Size);
        }
    }
}
