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

public class MultipassBitmap : BaseBitmap {
  private HandleRef swigCPtr;

  internal MultipassBitmap(IntPtr cPtr, bool cMemoryOwn) : base(C4dApiPINVOKE.MultipassBitmap_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MultipassBitmap obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public int GetLayerCount() {
    int ret = C4dApiPINVOKE.MultipassBitmap_GetLayerCount(swigCPtr);
    return ret;
  }

  public int GetAlphaLayerCount() {
    int ret = C4dApiPINVOKE.MultipassBitmap_GetAlphaLayerCount(swigCPtr);
    return ret;
  }

  public int GetHiddenLayerCount() {
    int ret = C4dApiPINVOKE.MultipassBitmap_GetHiddenLayerCount(swigCPtr);
    return ret;
  }

  public MultipassBitmap GetSelectedLayer() {
    IntPtr cPtr = C4dApiPINVOKE.MultipassBitmap_GetSelectedLayer(swigCPtr);
    MultipassBitmap ret = (cPtr == IntPtr.Zero) ? null : new MultipassBitmap(cPtr, false);
    return ret;
  }

  public MultipassBitmap GetLayerNum(int num) {
    IntPtr cPtr = C4dApiPINVOKE.MultipassBitmap_GetLayerNum(swigCPtr, num);
    MultipassBitmap ret = (cPtr == IntPtr.Zero) ? null : new MultipassBitmap(cPtr, false);
    return ret;
  }

  public MultipassBitmap GetAlphaLayerNum(int num) {
    IntPtr cPtr = C4dApiPINVOKE.MultipassBitmap_GetAlphaLayerNum(swigCPtr, num);
    MultipassBitmap ret = (cPtr == IntPtr.Zero) ? null : new MultipassBitmap(cPtr, false);
    return ret;
  }

  public MultipassBitmap GetHiddenLayerNum(int num) {
    IntPtr cPtr = C4dApiPINVOKE.MultipassBitmap_GetHiddenLayerNum(swigCPtr, num);
    MultipassBitmap ret = (cPtr == IntPtr.Zero) ? null : new MultipassBitmap(cPtr, false);
    return ret;
  }

  public MultipassBitmap AddLayer(MultipassBitmap insertafter, COLORMODE colormode, bool hidden) {
    IntPtr cPtr = C4dApiPINVOKE.MultipassBitmap_AddLayer__SWIG_0(swigCPtr, MultipassBitmap.getCPtr(insertafter), (int)colormode, hidden);
    MultipassBitmap ret = (cPtr == IntPtr.Zero) ? null : new MultipassBitmap(cPtr, false);
    return ret;
  }

  public MultipassBitmap AddLayer(MultipassBitmap insertafter, COLORMODE colormode) {
    IntPtr cPtr = C4dApiPINVOKE.MultipassBitmap_AddLayer__SWIG_1(swigCPtr, MultipassBitmap.getCPtr(insertafter), (int)colormode);
    MultipassBitmap ret = (cPtr == IntPtr.Zero) ? null : new MultipassBitmap(cPtr, false);
    return ret;
  }

  public MultipassBitmap AddFolder(MultipassBitmap insertafter, bool hidden) {
    IntPtr cPtr = C4dApiPINVOKE.MultipassBitmap_AddFolder__SWIG_0(swigCPtr, MultipassBitmap.getCPtr(insertafter), hidden);
    MultipassBitmap ret = (cPtr == IntPtr.Zero) ? null : new MultipassBitmap(cPtr, false);
    return ret;
  }

  public MultipassBitmap AddFolder(MultipassBitmap insertafter) {
    IntPtr cPtr = C4dApiPINVOKE.MultipassBitmap_AddFolder__SWIG_1(swigCPtr, MultipassBitmap.getCPtr(insertafter));
    MultipassBitmap ret = (cPtr == IntPtr.Zero) ? null : new MultipassBitmap(cPtr, false);
    return ret;
  }

  public MultipassBitmap AddAlpha(MultipassBitmap insertafter, COLORMODE colormode) {
    IntPtr cPtr = C4dApiPINVOKE.MultipassBitmap_AddAlpha(swigCPtr, MultipassBitmap.getCPtr(insertafter), (int)colormode);
    MultipassBitmap ret = (cPtr == IntPtr.Zero) ? null : new MultipassBitmap(cPtr, false);
    return ret;
  }

  public bool DeleteLayer(SWIGTYPE_p_p_MultipassBitmap layer) {
    bool ret = C4dApiPINVOKE.MultipassBitmap_DeleteLayer(swigCPtr, SWIGTYPE_p_p_MultipassBitmap.getCPtr(layer));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MultipassBitmap FindUserID(int id, int subid) {
    IntPtr cPtr = C4dApiPINVOKE.MultipassBitmap_FindUserID__SWIG_0(swigCPtr, id, subid);
    MultipassBitmap ret = (cPtr == IntPtr.Zero) ? null : new MultipassBitmap(cPtr, false);
    return ret;
  }

  public MultipassBitmap FindUserID(int id) {
    IntPtr cPtr = C4dApiPINVOKE.MultipassBitmap_FindUserID__SWIG_1(swigCPtr, id);
    MultipassBitmap ret = (cPtr == IntPtr.Zero) ? null : new MultipassBitmap(cPtr, false);
    return ret;
  }

  public void ClearImageData() {
    C4dApiPINVOKE.MultipassBitmap_ClearImageData(swigCPtr);
  }

  public SWIGTYPE_p_PaintBitmap GetPaintBitmap() {
    IntPtr cPtr = C4dApiPINVOKE.MultipassBitmap_GetPaintBitmap(swigCPtr);
    SWIGTYPE_p_PaintBitmap ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_PaintBitmap(cPtr, false);
    return ret;
  }

  public void FreeHiddenLayers() {
    C4dApiPINVOKE.MultipassBitmap_FreeHiddenLayers(swigCPtr);
  }

  public void SetMasterAlpha(BaseBitmap master) {
    C4dApiPINVOKE.MultipassBitmap_SetMasterAlpha(swigCPtr, BaseBitmap.getCPtr(master));
  }

  public GeData GetParameter(MPBTYPE id) {
    GeData ret = new GeData(C4dApiPINVOKE.MultipassBitmap_GetParameter(swigCPtr, (int)id), true);
    return ret;
  }

  public bool SetParameter(MPBTYPE id, GeData par) {
    bool ret = C4dApiPINVOKE.MultipassBitmap_SetParameter(swigCPtr, (int)id, GeData.getCPtr(par));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static MultipassBitmap Alloc(int bx, int by, COLORMODE mode) {
    IntPtr cPtr = C4dApiPINVOKE.MultipassBitmap_Alloc(bx, by, (int)mode);
    MultipassBitmap ret = (cPtr == IntPtr.Zero) ? null : new MultipassBitmap(cPtr, false);
    return ret;
  }

  public static MultipassBitmap AllocWrapper(BaseBitmap bmp) {
    IntPtr cPtr = C4dApiPINVOKE.MultipassBitmap_AllocWrapper(BaseBitmap.getCPtr(bmp));
    MultipassBitmap ret = (cPtr == IntPtr.Zero) ? null : new MultipassBitmap(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_MultipassBitmap bc) {
    C4dApiPINVOKE.MultipassBitmap_Free(SWIGTYPE_p_p_MultipassBitmap.getCPtr(bc));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetLayers(SWIGTYPE_p_GeTempDynArrayT_BaseBitmap_t list, MPB_GETLAYERS flags) {
    bool ret = C4dApiPINVOKE.MultipassBitmap_GetLayers__SWIG_0(swigCPtr, SWIGTYPE_p_GeTempDynArrayT_BaseBitmap_t.getCPtr(list), (int)flags);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetLayers(SWIGTYPE_p_GeTempDynArrayT_BaseBitmap_t list) {
    bool ret = C4dApiPINVOKE.MultipassBitmap_GetLayers__SWIG_1(swigCPtr, SWIGTYPE_p_GeTempDynArrayT_BaseBitmap_t.getCPtr(list));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetLayers(SWIGTYPE_p_GeTempDynArrayT_MultipassBitmap_t list, MPB_GETLAYERS flags) {
    bool ret = C4dApiPINVOKE.MultipassBitmap_GetLayers__SWIG_2(swigCPtr, SWIGTYPE_p_GeTempDynArrayT_MultipassBitmap_t.getCPtr(list), (int)flags);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetLayers(SWIGTYPE_p_GeTempDynArrayT_MultipassBitmap_t list) {
    bool ret = C4dApiPINVOKE.MultipassBitmap_GetLayers__SWIG_3(swigCPtr, SWIGTYPE_p_GeTempDynArrayT_MultipassBitmap_t.getCPtr(list));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetTempColorProfile(ColorProfile profile, bool dithering) {
    bool ret = C4dApiPINVOKE.MultipassBitmap_SetTempColorProfile(swigCPtr, ColorProfile.getCPtr(profile), dithering);
    return ret;
  }

}

}
