﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CudaSharper
{
    public enum CudaError
    {
        Success = 0,
        ErrorMissingConfiguration = 1,
        ErrorMemoryAllocation = 2,
        ErrorInitializationError = 3,
        ErrorLaunchFailure = 4,
        ErrorPriorLaunchFailure = 5,
        ErrorLaunchTimeout = 6,
        ErrorLaunchOutOfResources = 7,
        ErrorInvalidDeviceFunction = 8,
        ErrorInvalidConfiguration = 9,
        ErrorInvalidDevice = 10,
        ErrorInvalidValue = 11,
        ErrorInvalidPitchValue = 12,
        ErrorInvalidSymbol = 13,
        ErrorMapBufferObjectFailed = 14,
        ErrorUnmapBufferObjectFailed = 15,
        ErrorInvalidHostPointer = 16,
        ErrorInvalidDevicePointer = 17,
        ErrorInvalidTexture = 18,
        ErrorInvalidTextureBinding = 19,
        ErrorInvalidChannelDescriptor = 20,
        ErrorInvalidMemcpyDirection = 21,
        ErrorInvalidFilterSetting = 26,
        ErrorInvalidNormSetting = 27,
        ErrorrtUnloading = 29,
        ErrorUnknown = 30,
        ErrorInvalidResourceHandle = 33,
        ErrorNotReady = 34,
        ErrorInsufficientDriver = 35,
        ErrorSetOnActiveProcess = 36,
        ErrorInvalidSurface = 37,
        ErrorNoDevice = 38,
        ErrorECCUncorrectable = 39,
        ErrorSharedObjectSymbolNotFound = 40,
        ErrorSharedObjectInitFailed = 41,
        ErrorUnsupportedLimit = 42,
        ErrorDuplicateVariableName = 43,
        ErrorDuplicateTextureName = 44,
        ErrorDuplicateSurfaceName = 45,
        ErrorDevicesUnavailable = 46,
        ErrorInvalidKernelImage = 47,
        ErrorNoKernelImageForDevice = 48,
        ErrorIncompatibleDriverContext = 49,
        ErrorPeerAccessAlreadyEnabled = 50,
        ErrorPeerAccessNotEnabled = 51,
        ErrorDeviceAlreadyInUse = 54,
        ErrorProfilerDisabled = 55,
        ErrorAssert = 59,
        ErrorTooManyPeers = 60,
        ErrorHostMemoryAlreadyRegistered = 61,
        ErrorHostMemoryNotRegistered = 62,
        ErrorOperatingSystem = 63,
        ErrorPeerAccessUnsupported = 64,
        ErrorLaunchMaxDepthExceeded = 65,
        ErrorLaunchFileScopedTex = 66,
        ErrorLaunchFileScopedSurf = 67,
        ErrorSyncDepthExceeded = 68,
        ErrorLaunchPendingCountExceeded = 69,
        ErrorNotPermitted = 70,
        ErrorNotSupported = 71,
        ErrorHardwareStackError = 72,
        ErrorIllegalInstruction = 73,
        ErrorMisalignedAddress = 74,
        ErrorInvalidAddressSpace = 75,
        ErrorInvalidPc = 76,
        ErrorIllegalAddress = 77,
        ErrorInvalidPtx = 78,
        ErrorInvalidGraphicsContext = 79,
        ErrorNvlinkUncorrectable = 80,
    }
}