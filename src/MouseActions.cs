// Copyright 2021-2022 Woohyun Shin
// SPDX-License-Identifier: GPL-3.0-only

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
