namespace SharpDX.DXGI
{
    /// <summary>
    /// <p> Resource data formats, including fully-typed and typeless formats. A list of modifiers at the bottom of the page more fully describes each format type. </p>
    /// </summary>
    /// <doc-id>bb173059</doc-id>
    /// <unmanaged>DXGI_FORMAT</unmanaged>
    /// <unmanaged-short>DXGI_FORMAT</unmanaged-short>
    public enum Format : System.Int32
    {
        /// <summary>
        /// <dd> <p>The format is not known.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_UNKNOWN</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_UNKNOWN</unmanaged-short>
        Unknown = unchecked ((System.Int32)(0)),
        /// <summary>
        /// <dd> <p>A four-component, 128-bit typeless format that supports 32 bits per channel including alpha. ?</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R32G32B32A32_TYPELESS</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R32G32B32A32_TYPELESS</unmanaged-short>
        R32G32B32A32_Typeless = unchecked ((System.Int32)(1)),
        /// <summary>
        /// <dd> <p>A four-component, 128-bit floating-point format that supports 32 bits per channel including alpha. 1,5,8</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R32G32B32A32_FLOAT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R32G32B32A32_FLOAT</unmanaged-short>
        R32G32B32A32_Float = unchecked ((System.Int32)(2)),
        /// <summary>
        /// <dd> <p>A four-component, 128-bit unsigned-integer format that supports 32 bits per channel including alpha. ?</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R32G32B32A32_UINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R32G32B32A32_UINT</unmanaged-short>
        R32G32B32A32_UInt = unchecked ((System.Int32)(3)),
        /// <summary>
        /// <dd> <p>A four-component, 128-bit signed-integer format that supports 32 bits per channel including alpha. ?</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R32G32B32A32_SINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R32G32B32A32_SINT</unmanaged-short>
        R32G32B32A32_SInt = unchecked ((System.Int32)(4)),
        /// <summary>
        /// <dd> <p>A three-component, 96-bit typeless format that supports 32 bits per color channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R32G32B32_TYPELESS</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R32G32B32_TYPELESS</unmanaged-short>
        R32G32B32_Typeless = unchecked ((System.Int32)(5)),
        /// <summary>
        /// <dd> <p>A three-component, 96-bit floating-point format that supports 32 bits per color channel.5,8</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R32G32B32_FLOAT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R32G32B32_FLOAT</unmanaged-short>
        R32G32B32_Float = unchecked ((System.Int32)(6)),
        /// <summary>
        /// <dd> <p>A three-component, 96-bit unsigned-integer format that supports 32 bits per color channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R32G32B32_UINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R32G32B32_UINT</unmanaged-short>
        R32G32B32_UInt = unchecked ((System.Int32)(7)),
        /// <summary>
        /// <dd> <p>A three-component, 96-bit signed-integer format that supports 32 bits per color channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R32G32B32_SINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R32G32B32_SINT</unmanaged-short>
        R32G32B32_SInt = unchecked ((System.Int32)(8)),
        /// <summary>
        /// <dd> <p>A four-component, 64-bit typeless format that supports 16 bits per channel including alpha.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R16G16B16A16_TYPELESS</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R16G16B16A16_TYPELESS</unmanaged-short>
        R16G16B16A16_Typeless = unchecked ((System.Int32)(9)),
        /// <summary>
        /// <dd> <p>A four-component, 64-bit floating-point format that supports 16 bits per channel including alpha.5,7</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R16G16B16A16_FLOAT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R16G16B16A16_FLOAT</unmanaged-short>
        R16G16B16A16_Float = unchecked ((System.Int32)(10)),
        /// <summary>
        /// <dd> <p>A four-component, 64-bit unsigned-normalized-integer format that supports 16 bits per channel including alpha.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R16G16B16A16_UNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R16G16B16A16_UNORM</unmanaged-short>
        R16G16B16A16_UNorm = unchecked ((System.Int32)(11)),
        /// <summary>
        /// <dd> <p>A four-component, 64-bit unsigned-integer format that supports 16 bits per channel including alpha.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R16G16B16A16_UINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R16G16B16A16_UINT</unmanaged-short>
        R16G16B16A16_UInt = unchecked ((System.Int32)(12)),
        /// <summary>
        /// <dd> <p>A four-component, 64-bit signed-normalized-integer format that supports 16 bits per channel including alpha.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R16G16B16A16_SNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R16G16B16A16_SNORM</unmanaged-short>
        R16G16B16A16_SNorm = unchecked ((System.Int32)(13)),
        /// <summary>
        /// <dd> <p>A four-component, 64-bit signed-integer format that supports 16 bits per channel including alpha.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R16G16B16A16_SINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R16G16B16A16_SINT</unmanaged-short>
        R16G16B16A16_SInt = unchecked ((System.Int32)(14)),
        /// <summary>
        /// <dd> <p>A two-component, 64-bit typeless format that supports 32 bits for the red channel and 32 bits for the green channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R32G32_TYPELESS</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R32G32_TYPELESS</unmanaged-short>
        R32G32_Typeless = unchecked ((System.Int32)(15)),
        /// <summary>
        /// <dd> <p>A two-component, 64-bit floating-point format that supports 32 bits for the red channel and 32 bits for the green channel.5,8</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R32G32_FLOAT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R32G32_FLOAT</unmanaged-short>
        R32G32_Float = unchecked ((System.Int32)(16)),
        /// <summary>
        /// <dd> <p>A two-component, 64-bit unsigned-integer format that supports 32 bits for the red channel and 32 bits for the green channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R32G32_UINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R32G32_UINT</unmanaged-short>
        R32G32_UInt = unchecked ((System.Int32)(17)),
        /// <summary>
        /// <dd> <p>A two-component, 64-bit signed-integer format that supports 32 bits for the red channel and 32 bits for the green channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R32G32_SINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R32G32_SINT</unmanaged-short>
        R32G32_SInt = unchecked ((System.Int32)(18)),
        /// <summary>
        /// <dd> <p>A two-component, 64-bit typeless format that supports 32 bits for the red channel, 8 bits for the green channel, and 24 bits are unused.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R32G8X24_TYPELESS</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R32G8X24_TYPELESS</unmanaged-short>
        R32G8X24_Typeless = unchecked ((System.Int32)(19)),
        /// <summary>
        /// <dd> <p>A 32-bit floating-point component, and two unsigned-integer components (with an additional 32 bits). This format supports 32-bit depth, 8-bit stencil, and 24 bits are unused.?</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_D32_FLOAT_S8X24_UINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_D32_FLOAT_S8X24_UINT</unmanaged-short>
        D32_Float_S8X24_UInt = unchecked ((System.Int32)(20)),
        /// <summary>
        /// <dd> <p>A 32-bit floating-point component, and two typeless components (with an additional 32 bits). This format supports 32-bit red channel, 8 bits are unused, and 24 bits are unused.?</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R32_FLOAT_X8X24_TYPELESS</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R32_FLOAT_X8X24_TYPELESS</unmanaged-short>
        R32_Float_X8X24_Typeless = unchecked ((System.Int32)(21)),
        /// <summary>
        /// <dd> <p>A 32-bit typeless component, and two unsigned-integer components (with an additional 32 bits). This format has 32 bits unused, 8 bits for green channel, and 24 bits are unused.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_X32_TYPELESS_G8X24_UINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_X32_TYPELESS_G8X24_UINT</unmanaged-short>
        X32_Typeless_G8X24_UInt = unchecked ((System.Int32)(22)),
        /// <summary>
        /// <dd> <p>A four-component, 32-bit typeless format that supports 10 bits for each color and 2 bits for alpha.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R10G10B10A2_TYPELESS</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R10G10B10A2_TYPELESS</unmanaged-short>
        R10G10B10A2_Typeless = unchecked ((System.Int32)(23)),
        /// <summary>
        /// <dd> <p>A four-component, 32-bit unsigned-normalized-integer format that supports 10 bits for each color and 2 bits for alpha.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R10G10B10A2_UNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R10G10B10A2_UNORM</unmanaged-short>
        R10G10B10A2_UNorm = unchecked ((System.Int32)(24)),
        /// <summary>
        /// <dd> <p>A four-component, 32-bit unsigned-integer format that supports 10 bits for each color and 2 bits for alpha.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R10G10B10A2_UINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R10G10B10A2_UINT</unmanaged-short>
        R10G10B10A2_UInt = unchecked ((System.Int32)(25)),
        /// <summary>
        /// <dd> <p>Three partial-precision floating-point numbers encoded into a single 32-bit value (a variant of s10e5, which is sign bit, 10-bit mantissa, and 5-bit biased (15) exponent).  There are no sign bits, and there is a 5-bit biased (15) exponent for each channel, 6-bit mantissa  for R and G, and a 5-bit mantissa for B, as shown in the following illustration.5,7</p> <p></p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R11G11B10_FLOAT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R11G11B10_FLOAT</unmanaged-short>
        R11G11B10_Float = unchecked ((System.Int32)(26)),
        /// <summary>
        /// <dd> <p>A four-component, 32-bit typeless format that supports 8 bits per channel including alpha.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R8G8B8A8_TYPELESS</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R8G8B8A8_TYPELESS</unmanaged-short>
        R8G8B8A8_Typeless = unchecked ((System.Int32)(27)),
        /// <summary>
        /// <dd> <p>A four-component, 32-bit unsigned-normalized-integer format that supports 8 bits per channel including alpha.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R8G8B8A8_UNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R8G8B8A8_UNORM</unmanaged-short>
        R8G8B8A8_UNorm = unchecked ((System.Int32)(28)),
        /// <summary>
        /// <dd> <p>A four-component, 32-bit unsigned-normalized integer sRGB format that supports 8 bits per channel including alpha.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R8G8B8A8_UNORM_SRGB</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R8G8B8A8_UNORM_SRGB</unmanaged-short>
        R8G8B8A8_UNorm_SRgb = unchecked ((System.Int32)(29)),
        /// <summary>
        /// <dd> <p>A four-component, 32-bit unsigned-integer format that supports 8 bits per channel including alpha.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R8G8B8A8_UINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R8G8B8A8_UINT</unmanaged-short>
        R8G8B8A8_UInt = unchecked ((System.Int32)(30)),
        /// <summary>
        /// <dd> <p>A four-component, 32-bit signed-normalized-integer format that supports 8 bits per channel including alpha.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R8G8B8A8_SNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R8G8B8A8_SNORM</unmanaged-short>
        R8G8B8A8_SNorm = unchecked ((System.Int32)(31)),
        /// <summary>
        /// <dd> <p>A four-component, 32-bit signed-integer format that supports 8 bits per channel including alpha.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R8G8B8A8_SINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R8G8B8A8_SINT</unmanaged-short>
        R8G8B8A8_SInt = unchecked ((System.Int32)(32)),
        /// <summary>
        /// <dd> <p>A two-component, 32-bit typeless format that supports 16 bits for the red channel and 16 bits for the green channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R16G16_TYPELESS</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R16G16_TYPELESS</unmanaged-short>
        R16G16_Typeless = unchecked ((System.Int32)(33)),
        /// <summary>
        /// <dd> <p>A two-component, 32-bit floating-point format that supports 16 bits for the red channel and 16 bits for the green channel.5,7</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R16G16_FLOAT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R16G16_FLOAT</unmanaged-short>
        R16G16_Float = unchecked ((System.Int32)(34)),
        /// <summary>
        /// <dd> <p>A two-component, 32-bit unsigned-normalized-integer format that supports 16 bits each for the green and red channels.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R16G16_UNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R16G16_UNORM</unmanaged-short>
        R16G16_UNorm = unchecked ((System.Int32)(35)),
        /// <summary>
        /// <dd> <p>A two-component, 32-bit unsigned-integer format that supports 16 bits for the red channel and 16 bits for the green channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R16G16_UINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R16G16_UINT</unmanaged-short>
        R16G16_UInt = unchecked ((System.Int32)(36)),
        /// <summary>
        /// <dd> <p>A two-component, 32-bit signed-normalized-integer format that supports 16 bits for the red channel and 16 bits for the green channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R16G16_SNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R16G16_SNORM</unmanaged-short>
        R16G16_SNorm = unchecked ((System.Int32)(37)),
        /// <summary>
        /// <dd> <p>A two-component, 32-bit signed-integer format that supports 16 bits for the red channel and 16 bits for the green channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R16G16_SINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R16G16_SINT</unmanaged-short>
        R16G16_SInt = unchecked ((System.Int32)(38)),
        /// <summary>
        /// <dd> <p>A single-component, 32-bit typeless format that supports 32 bits for the red channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R32_TYPELESS</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R32_TYPELESS</unmanaged-short>
        R32_Typeless = unchecked ((System.Int32)(39)),
        /// <summary>
        /// <dd> <p>A single-component, 32-bit floating-point format that supports 32 bits for depth.5,8</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_D32_FLOAT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_D32_FLOAT</unmanaged-short>
        D32_Float = unchecked ((System.Int32)(40)),
        /// <summary>
        /// <dd> <p>A single-component, 32-bit floating-point format that supports 32 bits for the red channel.5,8</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R32_FLOAT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R32_FLOAT</unmanaged-short>
        R32_Float = unchecked ((System.Int32)(41)),
        /// <summary>
        /// <dd> <p>A single-component, 32-bit unsigned-integer format that supports 32 bits for the red channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R32_UINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R32_UINT</unmanaged-short>
        R32_UInt = unchecked ((System.Int32)(42)),
        /// <summary>
        /// <dd> <p>A single-component, 32-bit signed-integer format that supports 32 bits for the red channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R32_SINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R32_SINT</unmanaged-short>
        R32_SInt = unchecked ((System.Int32)(43)),
        /// <summary>
        /// <dd> <p>A two-component, 32-bit typeless format that supports 24 bits for the red channel and 8 bits for the green channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R24G8_TYPELESS</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R24G8_TYPELESS</unmanaged-short>
        R24G8_Typeless = unchecked ((System.Int32)(44)),
        /// <summary>
        /// <dd> <p>A 32-bit z-buffer format that supports 24 bits for depth and 8 bits for stencil.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_D24_UNORM_S8_UINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_D24_UNORM_S8_UINT</unmanaged-short>
        D24_UNorm_S8_UInt = unchecked ((System.Int32)(45)),
        /// <summary>
        /// <dd> <p>A 32-bit format, that contains a 24 bit, single-component, unsigned-normalized integer, with an additional typeless 8 bits. This format has 24 bits red channel and 8 bits unused.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R24_UNORM_X8_TYPELESS</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R24_UNORM_X8_TYPELESS</unmanaged-short>
        R24_UNorm_X8_Typeless = unchecked ((System.Int32)(46)),
        /// <summary>
        /// <dd> <p>A 32-bit format, that contains a 24 bit, single-component, typeless format,  with an additional 8 bit unsigned integer component. This format has 24 bits unused and 8 bits green channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_X24_TYPELESS_G8_UINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_X24_TYPELESS_G8_UINT</unmanaged-short>
        X24_Typeless_G8_UInt = unchecked ((System.Int32)(47)),
        /// <summary>
        /// <dd> <p>A two-component, 16-bit typeless format that supports 8 bits for the red channel and 8 bits for the green channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R8G8_TYPELESS</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R8G8_TYPELESS</unmanaged-short>
        R8G8_Typeless = unchecked ((System.Int32)(48)),
        /// <summary>
        /// <dd> <p>A two-component, 16-bit unsigned-normalized-integer format that supports 8 bits for the red channel and 8 bits for the green channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R8G8_UNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R8G8_UNORM</unmanaged-short>
        R8G8_UNorm = unchecked ((System.Int32)(49)),
        /// <summary>
        /// <dd> <p>A two-component, 16-bit unsigned-integer format that supports 8 bits for the red channel and 8 bits for the green channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R8G8_UINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R8G8_UINT</unmanaged-short>
        R8G8_UInt = unchecked ((System.Int32)(50)),
        /// <summary>
        /// <dd> <p>A two-component, 16-bit signed-normalized-integer format that supports 8 bits for the red channel and 8 bits for the green channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R8G8_SNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R8G8_SNORM</unmanaged-short>
        R8G8_SNorm = unchecked ((System.Int32)(51)),
        /// <summary>
        /// <dd> <p>A two-component, 16-bit signed-integer format that supports 8 bits for the red channel and 8 bits for the green channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R8G8_SINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R8G8_SINT</unmanaged-short>
        R8G8_SInt = unchecked ((System.Int32)(52)),
        /// <summary>
        /// <dd> <p>A single-component, 16-bit typeless format that supports 16 bits for the red channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R16_TYPELESS</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R16_TYPELESS</unmanaged-short>
        R16_Typeless = unchecked ((System.Int32)(53)),
        /// <summary>
        /// <dd> <p>A single-component, 16-bit floating-point format that supports 16 bits for the red channel.5,7</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R16_FLOAT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R16_FLOAT</unmanaged-short>
        R16_Float = unchecked ((System.Int32)(54)),
        /// <summary>
        /// <dd> <p>A single-component, 16-bit unsigned-normalized-integer format that supports 16 bits for depth.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_D16_UNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_D16_UNORM</unmanaged-short>
        D16_UNorm = unchecked ((System.Int32)(55)),
        /// <summary>
        /// <dd> <p>A single-component, 16-bit unsigned-normalized-integer format that supports 16 bits for the red channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R16_UNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R16_UNORM</unmanaged-short>
        R16_UNorm = unchecked ((System.Int32)(56)),
        /// <summary>
        /// <dd> <p>A single-component, 16-bit unsigned-integer format that supports 16 bits for the red channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R16_UINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R16_UINT</unmanaged-short>
        R16_UInt = unchecked ((System.Int32)(57)),
        /// <summary>
        /// <dd> <p>A single-component, 16-bit signed-normalized-integer format that supports 16 bits for the red channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R16_SNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R16_SNORM</unmanaged-short>
        R16_SNorm = unchecked ((System.Int32)(58)),
        /// <summary>
        /// <dd> <p>A single-component, 16-bit signed-integer format that supports 16 bits for the red channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R16_SINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R16_SINT</unmanaged-short>
        R16_SInt = unchecked ((System.Int32)(59)),
        /// <summary>
        /// <dd> <p>A single-component, 8-bit typeless format that supports 8 bits for the red channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R8_TYPELESS</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R8_TYPELESS</unmanaged-short>
        R8_Typeless = unchecked ((System.Int32)(60)),
        /// <summary>
        /// <dd> <p>A single-component, 8-bit unsigned-normalized-integer format that supports 8 bits for the red channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R8_UNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R8_UNORM</unmanaged-short>
        R8_UNorm = unchecked ((System.Int32)(61)),
        /// <summary>
        /// <dd> <p>A single-component, 8-bit unsigned-integer format that supports 8 bits for the red channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R8_UINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R8_UINT</unmanaged-short>
        R8_UInt = unchecked ((System.Int32)(62)),
        /// <summary>
        /// <dd> <p>A single-component, 8-bit signed-normalized-integer format that supports 8 bits for the red channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R8_SNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R8_SNORM</unmanaged-short>
        R8_SNorm = unchecked ((System.Int32)(63)),
        /// <summary>
        /// <dd> <p>A single-component, 8-bit signed-integer format that supports 8 bits for the red channel.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R8_SINT</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R8_SINT</unmanaged-short>
        R8_SInt = unchecked ((System.Int32)(64)),
        /// <summary>
        /// <dd> <p>A single-component, 8-bit unsigned-normalized-integer format for alpha only.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_A8_UNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_A8_UNORM</unmanaged-short>
        A8_UNorm = unchecked ((System.Int32)(65)),
        /// <summary>
        /// <dd> <p>A single-component, 1-bit unsigned-normalized integer format that supports 1 bit for the red channel. ?.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R1_UNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R1_UNORM</unmanaged-short>
        R1_UNorm = unchecked ((System.Int32)(66)),
        /// <summary>
        /// <dd> <p>Three partial-precision floating-point numbers encoded into a single 32-bit value all sharing the same 5-bit exponent (variant of s10e5, which is sign bit, 10-bit mantissa, and 5-bit biased (15) exponent).  There is no sign bit, and there is a shared 5-bit biased (15) exponent and a 9-bit mantissa for each channel, as shown in the following illustration. 2,6,7.</p> <p></p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R9G9B9E5_SHAREDEXP</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R9G9B9E5_SHAREDEXP</unmanaged-short>
        R9G9B9E5_Sharedexp = unchecked ((System.Int32)(67)),
        /// <summary>
        /// <dd> <p>A four-component, 32-bit unsigned-normalized-integer format. This packed RGB format is analogous to the UYVY format. Each 32-bit block describes a pair of pixels: (R8, G8, B8) and (R8, G8, B8) where the R8/B8 values are repeated, and the G8 values are unique to each pixel. ?</p> <p>Width must be even.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R8G8_B8G8_UNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R8G8_B8G8_UNORM</unmanaged-short>
        R8G8_B8G8_UNorm = unchecked ((System.Int32)(68)),
        /// <summary>
        /// <dd> <p>A four-component, 32-bit unsigned-normalized-integer format. This packed RGB format is analogous to the YUY2 format. Each 32-bit block describes a pair of pixels: (R8, G8, B8) and (R8, G8, B8) where the R8/B8 values are repeated, and the G8 values are unique to each pixel. ?</p> <p>Width must be even.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_G8R8_G8B8_UNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_G8R8_G8B8_UNORM</unmanaged-short>
        G8R8_G8B8_UNorm = unchecked ((System.Int32)(69)),
        /// <summary>
        /// <dd> <p>Four-component typeless block-compression format. For information about block-compression formats, see Texture Block Compression in Direct3D 11.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_BC1_TYPELESS</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_BC1_TYPELESS</unmanaged-short>
        BC1_Typeless = unchecked ((System.Int32)(70)),
        /// <summary>
        /// <dd> <p>Four-component block-compression format. For information about block-compression formats, see Texture Block Compression in Direct3D 11.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_BC1_UNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_BC1_UNORM</unmanaged-short>
        BC1_UNorm = unchecked ((System.Int32)(71)),
        /// <summary>
        /// <dd> <p>Four-component block-compression format for sRGB data. For information about block-compression formats, see Texture Block Compression in Direct3D 11.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_BC1_UNORM_SRGB</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_BC1_UNORM_SRGB</unmanaged-short>
        BC1_UNorm_SRgb = unchecked ((System.Int32)(72)),
        /// <summary>
        /// <dd> <p>Four-component typeless block-compression format. For information about block-compression formats, see Texture Block Compression in Direct3D 11.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_BC2_TYPELESS</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_BC2_TYPELESS</unmanaged-short>
        BC2_Typeless = unchecked ((System.Int32)(73)),
        /// <summary>
        /// <dd> <p>Four-component block-compression format. For information about block-compression formats, see Texture Block Compression in Direct3D 11.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_BC2_UNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_BC2_UNORM</unmanaged-short>
        BC2_UNorm = unchecked ((System.Int32)(74)),
        /// <summary>
        /// <dd> <p>Four-component block-compression format for sRGB data. For information about block-compression formats, see Texture Block Compression in Direct3D 11.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_BC2_UNORM_SRGB</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_BC2_UNORM_SRGB</unmanaged-short>
        BC2_UNorm_SRgb = unchecked ((System.Int32)(75)),
        /// <summary>
        /// <dd> <p>Four-component typeless block-compression format. For information about block-compression formats, see Texture Block Compression in Direct3D 11.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_BC3_TYPELESS</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_BC3_TYPELESS</unmanaged-short>
        BC3_Typeless = unchecked ((System.Int32)(76)),
        /// <summary>
        /// <dd> <p>Four-component block-compression format. For information about block-compression formats, see Texture Block Compression in Direct3D 11.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_BC3_UNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_BC3_UNORM</unmanaged-short>
        BC3_UNorm = unchecked ((System.Int32)(77)),
        /// <summary>
        /// <dd> <p>Four-component block-compression format for sRGB data. For information about block-compression formats, see Texture Block Compression in Direct3D 11.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_BC3_UNORM_SRGB</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_BC3_UNORM_SRGB</unmanaged-short>
        BC3_UNorm_SRgb = unchecked ((System.Int32)(78)),
        /// <summary>
        /// <dd> <p>One-component typeless block-compression format. For information about block-compression formats, see Texture Block Compression in Direct3D 11.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_BC4_TYPELESS</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_BC4_TYPELESS</unmanaged-short>
        BC4_Typeless = unchecked ((System.Int32)(79)),
        /// <summary>
        /// <dd> <p>One-component block-compression format. For information about block-compression formats, see Texture Block Compression in Direct3D 11.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_BC4_UNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_BC4_UNORM</unmanaged-short>
        BC4_UNorm = unchecked ((System.Int32)(80)),
        /// <summary>
        /// <dd> <p>One-component block-compression format. For information about block-compression formats, see Texture Block Compression in Direct3D 11.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_BC4_SNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_BC4_SNORM</unmanaged-short>
        BC4_SNorm = unchecked ((System.Int32)(81)),
        /// <summary>
        /// <dd> <p>Two-component typeless block-compression format. For information about block-compression formats, see Texture Block Compression in Direct3D 11.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_BC5_TYPELESS</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_BC5_TYPELESS</unmanaged-short>
        BC5_Typeless = unchecked ((System.Int32)(82)),
        /// <summary>
        /// <dd> <p>Two-component block-compression format. For information about block-compression formats, see Texture Block Compression in Direct3D 11.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_BC5_UNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_BC5_UNORM</unmanaged-short>
        BC5_UNorm = unchecked ((System.Int32)(83)),
        /// <summary>
        /// <dd> <p>Two-component block-compression format. For information about block-compression formats, see Texture Block Compression in Direct3D 11.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_BC5_SNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_BC5_SNORM</unmanaged-short>
        BC5_SNorm = unchecked ((System.Int32)(84)),
        /// <summary>
        /// <dd> <p>A three-component, 16-bit unsigned-normalized-integer format that supports 5 bits for blue, 6 bits for green, and 5 bits for red.</p> <p><strong>Direct3D 10 through Direct3D 11:??</strong>This value is defined for DXGI. However, Direct3D 10, 10.1, or 11 devices do not support this format.</p> <p><strong>Direct3D 11.1:??</strong>This value is not supported until Windows?8.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_B5G6R5_UNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_B5G6R5_UNORM</unmanaged-short>
        B5G6R5_UNorm = unchecked ((System.Int32)(85)),
        /// <summary>
        /// <dd> <p>A four-component, 16-bit unsigned-normalized-integer format that supports 5 bits for each color channel and 1-bit alpha.</p> <p><strong>Direct3D 10 through Direct3D 11:??</strong>This value is defined for DXGI. However, Direct3D 10, 10.1, or 11 devices do not support this format.</p> <p><strong>Direct3D 11.1:??</strong>This value is not supported until Windows?8.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_B5G5R5A1_UNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_B5G5R5A1_UNORM</unmanaged-short>
        B5G5R5A1_UNorm = unchecked ((System.Int32)(86)),
        /// <summary>
        /// <dd> <p>A four-component, 32-bit unsigned-normalized-integer format that supports 8 bits for each color channel and 8-bit alpha.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_B8G8R8A8_UNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_B8G8R8A8_UNORM</unmanaged-short>
        B8G8R8A8_UNorm = unchecked ((System.Int32)(87)),
        /// <summary>
        /// <dd> <p>A four-component, 32-bit unsigned-normalized-integer format that supports 8 bits for each color channel and 8 bits unused.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_B8G8R8X8_UNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_B8G8R8X8_UNORM</unmanaged-short>
        B8G8R8X8_UNorm = unchecked ((System.Int32)(88)),
        /// <summary>
        /// <dd> <p>A four-component, 32-bit 2.8-biased fixed-point format that supports 10 bits for each color channel and 2-bit alpha.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_R10G10B10_XR_BIAS_A2_UNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_R10G10B10_XR_BIAS_A2_UNORM</unmanaged-short>
        R10G10B10_Xr_Bias_A2_UNorm = unchecked ((System.Int32)(89)),
        /// <summary>
        /// <dd> <p>A four-component, 32-bit typeless format that supports 8 bits for each channel including alpha. ?</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_B8G8R8A8_TYPELESS</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_B8G8R8A8_TYPELESS</unmanaged-short>
        B8G8R8A8_Typeless = unchecked ((System.Int32)(90)),
        /// <summary>
        /// <dd> <p>A four-component, 32-bit unsigned-normalized standard RGB format that supports 8 bits for each channel including alpha. ?</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_B8G8R8A8_UNORM_SRGB</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_B8G8R8A8_UNORM_SRGB</unmanaged-short>
        B8G8R8A8_UNorm_SRgb = unchecked ((System.Int32)(91)),
        /// <summary>
        /// <dd> <p>A four-component, 32-bit typeless format that supports 8 bits for each color channel, and 8 bits are unused. ?</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_B8G8R8X8_TYPELESS</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_B8G8R8X8_TYPELESS</unmanaged-short>
        B8G8R8X8_Typeless = unchecked ((System.Int32)(92)),
        /// <summary>
        /// <dd> <p>A four-component, 32-bit unsigned-normalized standard RGB format that supports 8 bits for each color channel, and 8 bits are unused. ?</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_B8G8R8X8_UNORM_SRGB</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_B8G8R8X8_UNORM_SRGB</unmanaged-short>
        B8G8R8X8_UNorm_SRgb = unchecked ((System.Int32)(93)),
        /// <summary>
        /// <dd> <p>A typeless block-compression format. ? For information about block-compression formats, see Texture Block Compression in Direct3D 11.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_BC6H_TYPELESS</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_BC6H_TYPELESS</unmanaged-short>
        BC6H_Typeless = unchecked ((System.Int32)(94)),
        /// <summary>
        /// <dd> <p>A block-compression format. ? For information about block-compression formats, see Texture Block Compression in Direct3D 11.?</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_BC6H_UF16</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_BC6H_UF16</unmanaged-short>
        BC6H_Uf16 = unchecked ((System.Int32)(95)),
        /// <summary>
        /// <dd> <p>A block-compression format. ? For information about block-compression formats, see Texture Block Compression in Direct3D 11.?</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_BC6H_SF16</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_BC6H_SF16</unmanaged-short>
        BC6H_Sf16 = unchecked ((System.Int32)(96)),
        /// <summary>
        /// <dd> <p>A typeless block-compression format. ? For information about block-compression formats, see Texture Block Compression in Direct3D 11.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_BC7_TYPELESS</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_BC7_TYPELESS</unmanaged-short>
        BC7_Typeless = unchecked ((System.Int32)(97)),
        /// <summary>
        /// <dd> <p>A block-compression format. ? For information about block-compression formats, see Texture Block Compression in Direct3D 11.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_BC7_UNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_BC7_UNORM</unmanaged-short>
        BC7_UNorm = unchecked ((System.Int32)(98)),
        /// <summary>
        /// <dd> <p>A block-compression format. ? For information about block-compression formats, see Texture Block Compression in Direct3D 11.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_BC7_UNORM_SRGB</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_BC7_UNORM_SRGB</unmanaged-short>
        BC7_UNorm_SRgb = unchecked ((System.Int32)(99)),
        /// <summary>
        /// <dd> <p>Most common YUV 4:4:4 video resource format. Valid view formats for this video resource format are DXGI_FORMAT_R8G8B8A8_UNORM and DXGI_FORMAT_R8G8B8A8_UINT. For UAVs, an additional valid view format is DXGI_FORMAT_R32_UINT. By using DXGI_FORMAT_R32_UINT for UAVs, you can both read and write as opposed to just write for DXGI_FORMAT_R8G8B8A8_UNORM and DXGI_FORMAT_R8G8B8A8_UINT. Supported view types are SRV, RTV, and UAV. One view provides a straightforward mapping of the entire surface. The mapping to the view channel is V-&gt;R8, 
        /// U-&gt;G8, 
        /// Y-&gt;B8, 
        /// and A-&gt;A8.</p> <p>For more info about YUV formats for video rendering, see Recommended 8-Bit YUV Formats for Video Rendering. </p> <p><strong>Direct3D 11.1:??</strong>This value is not supported until Windows?8.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_AYUV</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_AYUV</unmanaged-short>
        AYUV = unchecked ((System.Int32)(100)),
        /// <summary>
        /// <dd> <p>10-bit per channel packed YUV 4:4:4 video resource format. Valid view formats for this video resource format are DXGI_FORMAT_R10G10B10A2_UNORM and DXGI_FORMAT_R10G10B10A2_UINT. For UAVs, an additional valid view format is DXGI_FORMAT_R32_UINT. By using DXGI_FORMAT_R32_UINT for UAVs, you can both read and write as opposed to just write for DXGI_FORMAT_R10G10B10A2_UNORM and DXGI_FORMAT_R10G10B10A2_UINT. Supported view types are SRV and UAV. One view provides a straightforward mapping of the entire surface. The mapping to the view channel is U-&gt;R10,
        /// Y-&gt;G10,
        /// V-&gt;B10,
        /// and A-&gt;A2.</p> <p>For more info about YUV formats for video rendering, see Recommended 8-Bit YUV Formats for Video Rendering. </p> <p><strong>Direct3D 11.1:??</strong>This value is not supported until Windows?8.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_Y410</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_Y410</unmanaged-short>
        Y410 = unchecked ((System.Int32)(101)),
        /// <summary>
        /// <dd> <p>16-bit per channel packed YUV 4:4:4 video resource format. Valid view formats for this video resource format are DXGI_FORMAT_R16G16B16A16_UNORM and DXGI_FORMAT_R16G16B16A16_UINT. Supported view types are SRV and UAV. One view provides a straightforward mapping of the entire surface. The mapping to the view channel is U-&gt;R16,
        /// Y-&gt;G16,
        /// V-&gt;B16,
        /// and A-&gt;A16.</p> <p>For more info about YUV formats for video rendering, see Recommended 8-Bit YUV Formats for Video Rendering. </p> <p><strong>Direct3D 11.1:??</strong>This value is not supported until Windows?8.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_Y416</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_Y416</unmanaged-short>
        Y416 = unchecked ((System.Int32)(102)),
        /// <summary>
        /// <dd> <p>Most common YUV 4:2:0 video resource format. Valid luminance data view formats for this video resource format are DXGI_FORMAT_R8_UNORM and DXGI_FORMAT_R8_UINT. Valid chrominance data view formats (width and height are each 1/2 of luminance view) for this video resource format are DXGI_FORMAT_R8G8_UNORM and DXGI_FORMAT_R8G8_UINT. Supported view types are SRV, RTV, and UAV. For luminance data view, the mapping to the view channel is Y-&gt;R8. For chrominance data view, the mapping to the view channel is U-&gt;R8 and
        /// V-&gt;G8.</p> <p>For more info about YUV formats for video rendering, see Recommended 8-Bit YUV Formats for Video Rendering. </p> <p>Width and height must be even. Direct3D 11 staging resources and initData parameters for this format use (rowPitch * (height + (height / 2))) bytes. The first (SysMemPitch * height) bytes are the Y plane, the remaining (SysMemPitch * (height / 2)) bytes are the UV plane.</p> <p>An app using the YUY 4:2:0 formats  must map the luma (Y) plane separately from the chroma (UV) planes. Developers do this by calling <strong>ID3D12Device::CreateShaderResourceView</strong> twice for the same texture and passing in 1-channel and 2-channel formats. Passing in a 1-channel format compatible with the Y plane maps only the Y plane. Passing in a 2-channel format compatible with the UV planes (together) maps only the U and V planes as a single resource view.</p> <p><strong>Direct3D 11.1:??</strong>This value is not supported until Windows?8.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_NV12</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_NV12</unmanaged-short>
        NV12 = unchecked ((System.Int32)(103)),
        /// <summary>
        /// <dd> <p>10-bit per channel planar YUV 4:2:0 video resource format. Valid luminance data view formats for this video resource format are DXGI_FORMAT_R16_UNORM and DXGI_FORMAT_R16_UINT. The runtime does not enforce whether the lowest 6 bits are 0 (given that this video resource format is a 10-bit format that uses 16 bits). If required, application shader code would have to enforce this manually.  From the runtime's point of view, DXGI_FORMAT_P010 is no different than DXGI_FORMAT_P016. Valid chrominance data view formats (width and height are each 1/2 of luminance view) for this video resource format are DXGI_FORMAT_R16G16_UNORM and DXGI_FORMAT_R16G16_UINT. For UAVs, an additional valid chrominance data view format is DXGI_FORMAT_R32_UINT. By using DXGI_FORMAT_R32_UINT for UAVs, you can both read and write as opposed to just write for DXGI_FORMAT_R16G16_UNORM and DXGI_FORMAT_R16G16_UINT. Supported view types are SRV, RTV, and UAV. For luminance data view, the mapping to the view channel is Y-&gt;R16. For chrominance data view, the mapping to the view channel is U-&gt;R16 and
        /// V-&gt;G16.</p> <p>For more info about YUV formats for video rendering, see Recommended 8-Bit YUV Formats for Video Rendering. </p> <p>Width and height must be even. Direct3D 11 staging resources and initData parameters for this format use (rowPitch * (height + (height / 2))) bytes. The first (SysMemPitch * height) bytes are the Y plane, the remaining (SysMemPitch * (height / 2)) bytes are the UV plane.</p> <p>An app using the YUY 4:2:0 formats  must map the luma (Y) plane separately from the chroma (UV) planes. Developers do this by calling <strong>ID3D12Device::CreateShaderResourceView</strong> twice for the same texture and passing in 1-channel and 2-channel formats. Passing in a 1-channel format compatible with the Y plane maps only the Y plane. Passing in a 2-channel format compatible with the UV planes (together) maps only the U and V planes as a single resource view.</p> <p><strong>Direct3D 11.1:??</strong>This value is not supported until Windows?8.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_P010</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_P010</unmanaged-short>
        P010 = unchecked ((System.Int32)(104)),
        /// <summary>
        /// <dd> <p>16-bit per channel planar YUV 4:2:0 video resource format. Valid luminance data view formats for this video resource format are DXGI_FORMAT_R16_UNORM and DXGI_FORMAT_R16_UINT. Valid chrominance data view formats (width and height are each 1/2 of luminance view) for this video resource format are DXGI_FORMAT_R16G16_UNORM and DXGI_FORMAT_R16G16_UINT. For UAVs, an additional valid chrominance data view format is DXGI_FORMAT_R32_UINT. By using DXGI_FORMAT_R32_UINT for UAVs, you can both read and write as opposed to just write for DXGI_FORMAT_R16G16_UNORM and DXGI_FORMAT_R16G16_UINT. Supported view types are SRV, RTV, and UAV. For luminance data view, the mapping to the view channel is Y-&gt;R16. For chrominance data view, the mapping to the view channel is U-&gt;R16 and
        /// V-&gt;G16.</p> <p>For more info about YUV formats for video rendering, see Recommended 8-Bit YUV Formats for Video Rendering. </p> <p>Width and height must be even. Direct3D 11 staging resources and initData parameters for this format use (rowPitch * (height + (height / 2))) bytes. The first (SysMemPitch * height) bytes are the Y plane, the remaining (SysMemPitch * (height / 2)) bytes are the UV plane.</p> <p>An app using the YUY 4:2:0 formats  must map the luma (Y) plane separately from the chroma (UV) planes. Developers do this by calling <strong>ID3D12Device::CreateShaderResourceView</strong> twice for the same texture and passing in 1-channel and 2-channel formats. Passing in a 1-channel format compatible with the Y plane maps only the Y plane. Passing in a 2-channel format compatible with the UV planes (together) maps only the U and V planes as a single resource view.</p> <p><strong>Direct3D 11.1:??</strong>This value is not supported until Windows?8.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_P016</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_P016</unmanaged-short>
        P016 = unchecked ((System.Int32)(105)),
        /// <summary>
        /// <dd> <p>8-bit per channel planar YUV 4:2:0 video resource format. This format is subsampled where each pixel has its own Y value, but each 2x2 pixel block shares a single U and V value. The runtime requires that the width and height of all resources that are created with this format are multiples of 2. The runtime also requires that the left, right, top, and bottom members of any <see cref = "SharpDX.Mathematics.Interop.RawRectangle"/> that are used for this format are multiples of 2. This format differs from DXGI_FORMAT_NV12 in that the layout of the data within the resource is completely opaque to applications. Applications cannot use the CPU to map the resource and then access the data within the resource. You cannot use shaders with this format. Because of this behavior, legacy hardware that supports a non-NV12 4:2:0 layout (for example, YV12, and so on) can be used. Also, new hardware that has a 4:2:0 implementation better than NV12 can be used when the application does not need the data to be in a standard layout. </p> <p>For more info about YUV formats for video rendering, see Recommended 8-Bit YUV Formats for Video Rendering. </p> <p>Width and height must be even. Direct3D 11 staging resources and initData parameters for this format use (rowPitch * (height + (height / 2))) bytes. </p> <p>An app using the YUY 4:2:0 formats  must map the luma (Y) plane separately from the chroma (UV) planes. Developers do this by calling <strong>ID3D12Device::CreateShaderResourceView</strong> twice for the same texture and passing in 1-channel and 2-channel formats. Passing in a 1-channel format compatible with the Y plane maps only the Y plane. Passing in a 2-channel format compatible with the UV planes (together) maps only the U and V planes as a single resource view.</p> <p><strong>Direct3D 11.1:??</strong>This value is not supported until Windows?8.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_420_OPAQUE</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_420_OPAQUE</unmanaged-short>
        Opaque420 = unchecked ((System.Int32)(106)),
        /// <summary>
        /// <dd> <p>Most common YUV 4:2:2 video resource format. Valid view formats for this video resource format are DXGI_FORMAT_R8G8B8A8_UNORM and DXGI_FORMAT_R8G8B8A8_UINT. For UAVs, an additional valid view format is DXGI_FORMAT_R32_UINT. By using DXGI_FORMAT_R32_UINT for UAVs, you can both read and write as opposed to just write for DXGI_FORMAT_R8G8B8A8_UNORM and DXGI_FORMAT_R8G8B8A8_UINT. Supported view types are SRV and UAV. One view provides a straightforward mapping of the entire surface. The mapping to the view channel is Y0-&gt;R8, 
        /// U0-&gt;G8, 
        /// Y1-&gt;B8, 
        /// and V0-&gt;A8.</p> <p>A unique valid view format for this video resource format is DXGI_FORMAT_R8G8_B8G8_UNORM. With this view format, the width of the view appears to be twice what the DXGI_FORMAT_R8G8B8A8_UNORM or DXGI_FORMAT_R8G8B8A8_UINT view would be when hardware reconstructs RGBA automatically on read and before filtering.  This Direct3D hardware behavior is legacy and is likely not useful any more. With this view format, the mapping to the view channel is Y0-&gt;R8, 
        /// U0-&gt;
        /// G8[0], 
        /// Y1-&gt;B8, 
        /// and V0-&gt;
        /// G8[1].</p> <p>For more info about YUV formats for video rendering, see Recommended 8-Bit YUV Formats for Video Rendering. </p> <p>Width must be even.</p> <p><strong>Direct3D 11.1:??</strong>This value is not supported until Windows?8.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_YUY2</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_YUY2</unmanaged-short>
        YUY2 = unchecked ((System.Int32)(107)),
        /// <summary>
        /// <dd> <p>10-bit per channel packed YUV 4:2:2 video resource format. Valid view formats for this video resource format are DXGI_FORMAT_R16G16B16A16_UNORM and DXGI_FORMAT_R16G16B16A16_UINT. The runtime does not enforce whether the lowest 6 bits are 0 (given that this video resource format is a 10-bit format that uses 16 bits). If required, application shader code would have to enforce this manually.  From the runtime's point of view, DXGI_FORMAT_Y210 is no different than DXGI_FORMAT_Y216. Supported view types are SRV and UAV. One view provides a straightforward mapping of the entire surface. The mapping to the view channel is Y0-&gt;R16,
        /// U-&gt;G16,
        /// Y1-&gt;B16,
        /// and V-&gt;A16.</p> <p>For more info about YUV formats for video rendering, see Recommended 8-Bit YUV Formats for Video Rendering. </p> <p>Width must be even.</p> <p><strong>Direct3D 11.1:??</strong>This value is not supported until Windows?8.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_Y210</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_Y210</unmanaged-short>
        Y210 = unchecked ((System.Int32)(108)),
        /// <summary>
        /// <dd> <p>16-bit per channel packed YUV 4:2:2 video resource format. Valid view formats for this video resource format are DXGI_FORMAT_R16G16B16A16_UNORM and DXGI_FORMAT_R16G16B16A16_UINT. Supported view types are SRV and UAV. One view provides a straightforward mapping of the entire surface. The mapping to the view channel is Y0-&gt;R16,
        /// U-&gt;G16,
        /// Y1-&gt;B16,
        /// and V-&gt;A16.</p> <p>For more info about YUV formats for video rendering, see Recommended 8-Bit YUV Formats for Video Rendering. </p> <p>Width must be even.</p> <p><strong>Direct3D 11.1:??</strong>This value is not supported until Windows?8.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_Y216</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_Y216</unmanaged-short>
        Y216 = unchecked ((System.Int32)(109)),
        /// <summary>
        /// <dd> <p>Most common planar YUV 4:1:1 video resource format. Valid luminance data view formats for this video resource format are DXGI_FORMAT_R8_UNORM and DXGI_FORMAT_R8_UINT. Valid chrominance data view formats (width and height are each 1/4 of luminance view) for this video resource format are DXGI_FORMAT_R8G8_UNORM and DXGI_FORMAT_R8G8_UINT. Supported view types are SRV, RTV, and UAV. For luminance data view, the mapping to the view channel is Y-&gt;R8. For chrominance data view, the mapping to the view channel is U-&gt;R8 and
        /// V-&gt;G8.</p> <p>For more info about YUV formats for video rendering, see Recommended 8-Bit YUV Formats for Video Rendering. </p> <p>Width must be a multiple of 4. Direct3D11 staging resources and initData parameters for this format use (rowPitch * height * 2) bytes. The first (SysMemPitch * height) bytes are the Y plane, the next ((SysMemPitch / 2) * height) bytes are the UV plane, and the remainder is padding. </p> <p><strong>Direct3D 11.1:??</strong>This value is not supported until Windows?8.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_NV11</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_NV11</unmanaged-short>
        NV11 = unchecked ((System.Int32)(110)),
        /// <summary>
        /// <dd> <p>4-bit palletized YUV format that is commonly used for DVD subpicture.</p> <p>For more info about YUV formats for video rendering, see Recommended 8-Bit YUV Formats for Video Rendering. </p> <p><strong>Direct3D 11.1:??</strong>This value is not supported until Windows?8.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_AI44</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_AI44</unmanaged-short>
        AI44 = unchecked ((System.Int32)(111)),
        /// <summary>
        /// <dd> <p>4-bit palletized YUV format that is commonly used for DVD subpicture.</p> <p>For more info about YUV formats for video rendering, see Recommended 8-Bit YUV Formats for Video Rendering. </p> <p><strong>Direct3D 11.1:??</strong>This value is not supported until Windows?8.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_IA44</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_IA44</unmanaged-short>
        IA44 = unchecked ((System.Int32)(112)),
        /// <summary>
        /// <dd> <p>8-bit palletized format that is used for palletized RGB data when the processor processes ISDB-T data and for palletized YUV data when the processor processes BluRay data.</p> <p>For more info about YUV formats for video rendering, see Recommended 8-Bit YUV Formats for Video Rendering. </p> <p><strong>Direct3D 11.1:??</strong>This value is not supported until Windows?8.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_P8</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_P8</unmanaged-short>
        P8 = unchecked ((System.Int32)(113)),
        /// <summary>
        /// <dd> <p>8-bit palletized format with 8 bits of alpha that is used for palletized YUV data when the processor processes BluRay data.</p> <p>For more info about YUV formats for video rendering, see Recommended 8-Bit YUV Formats for Video Rendering. </p> <p><strong>Direct3D 11.1:??</strong>This value is not supported until Windows?8.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_A8P8</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_A8P8</unmanaged-short>
        A8P8 = unchecked ((System.Int32)(114)),
        /// <summary>
        /// <dd> <p>A four-component, 16-bit unsigned-normalized integer format that supports 4 bits for each channel including alpha.</p> <p><strong>Direct3D 11.1:??</strong>This value is not supported until Windows?8.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_B4G4R4A4_UNORM</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_B4G4R4A4_UNORM</unmanaged-short>
        B4G4R4A4_UNorm = unchecked ((System.Int32)(115)),
        /// <summary>
        /// <dd> <p>A video format; an 8-bit version of a hybrid planar 4:2:2 format.</p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_P208</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_P208</unmanaged-short>
        P208 = unchecked ((System.Int32)(130)),
        /// <summary>
        /// <dd> <p>An 8 bit YCbCrA 4:4 rendering format. </p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_V208</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_V208</unmanaged-short>
        V208 = unchecked ((System.Int32)(131)),
        /// <summary>
        /// <dd> <p>An 8 bit YCbCrA 4:4:4:4 rendering format. </p> </dd>
        /// </summary>
        /// <doc-id>bb173059</doc-id>
        /// <unmanaged>DXGI_FORMAT_V408</unmanaged>
        /// <unmanaged-short>DXGI_FORMAT_V408</unmanaged-short>
        V408 = unchecked ((System.Int32)(132))}
}