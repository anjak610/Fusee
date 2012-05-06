/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 0.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

using System;
using System.Runtime.InteropServices;

public class ColorProfileConvert : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ColorProfileConvert(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ColorProfileConvert obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public static ColorProfileConvert Alloc() {
    IntPtr cPtr = C4dApiPINVOKE.ColorProfileConvert_Alloc();
    ColorProfileConvert ret = (cPtr == IntPtr.Zero) ? null : new ColorProfileConvert(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_ColorProfileConvert convert) {
    C4dApiPINVOKE.ColorProfileConvert_Free(SWIGTYPE_p_p_ColorProfileConvert.getCPtr(convert));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool PrepareTransform(COLORMODE srccolormode, ColorProfile srcprofile, COLORMODE dstcolormode, ColorProfile dstprofile, bool bgr) {
    bool ret = C4dApiPINVOKE.ColorProfileConvert_PrepareTransform(swigCPtr, (int)srccolormode, ColorProfile.getCPtr(srcprofile), (int)dstcolormode, ColorProfile.getCPtr(dstprofile), bgr);
    return ret;
  }

  public void Convert(SWIGTYPE_p_UCHAR src, SWIGTYPE_p_UCHAR dst, int cnt, int SkipInputComponents, int SkipOutputComponents) {
    C4dApiPINVOKE.ColorProfileConvert_Convert(swigCPtr, SWIGTYPE_p_UCHAR.getCPtr(src), SWIGTYPE_p_UCHAR.getCPtr(dst), cnt, SkipInputComponents, SkipOutputComponents);
  }

}

}
