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

public class BaseView : BaseList2D {
  private HandleRef swigCPtr;

  internal BaseView(IntPtr cPtr, bool cMemoryOwn) : base(C4dApiPINVOKE.BaseView_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BaseView obj) {
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

  public void GetFrame(SWIGTYPE_p_LONG cl, SWIGTYPE_p_LONG ct, SWIGTYPE_p_LONG cr, SWIGTYPE_p_LONG cb) {
    C4dApiPINVOKE.BaseView_GetFrame(swigCPtr, SWIGTYPE_p_LONG.getCPtr(cl), SWIGTYPE_p_LONG.getCPtr(ct), SWIGTYPE_p_LONG.getCPtr(cr), SWIGTYPE_p_LONG.getCPtr(cb));
  }

  public void GetSafeFrame(SWIGTYPE_p_LONG cl, SWIGTYPE_p_LONG ct, SWIGTYPE_p_LONG cr, SWIGTYPE_p_LONG cb) {
    C4dApiPINVOKE.BaseView_GetSafeFrame(swigCPtr, SWIGTYPE_p_LONG.getCPtr(cl), SWIGTYPE_p_LONG.getCPtr(ct), SWIGTYPE_p_LONG.getCPtr(cr), SWIGTYPE_p_LONG.getCPtr(cb));
  }

  public void GetViewParameter(ref Fusee.Math.Core.Vector3D /* Vector*&_cstype */ offset, ref Fusee.Math.Core.Vector3D /* Vector*&_cstype */ scale, ref Fusee.Math.Core.Vector3D /* Vector*&_cstype */ scale_z) {
    C4dApiPINVOKE.BaseView_GetViewParameter(swigCPtr, ref offset /* Vector*&_csin */, ref scale /* Vector*&_csin */, ref scale_z /* Vector*&_csin */);
  }

  public Fusee.Math.Core.Matrix4D /* Matrix_cstype */ GetMg()  {  /* <Matrix_csout> */
      C34M ret_c34m = C4dApiPINVOKE.BaseView_GetMg(swigCPtr);
	  Fusee.Math.Core.Matrix4D ret;
	  unsafe {ret = Fusee.Math.ArrayConversion.Convert.ArrayDoubleC4DLayoutToMatrix4D(ret_c34m.m);}
      return ret;
   } /* </Matrix_csout> */ 

  public Fusee.Math.Core.Matrix4D /* Matrix_cstype */ GetMi()  {  /* <Matrix_csout> */
      C34M ret_c34m = C4dApiPINVOKE.BaseView_GetMi(swigCPtr);
	  Fusee.Math.Core.Matrix4D ret;
	  unsafe {ret = Fusee.Math.ArrayConversion.Convert.ArrayDoubleC4DLayoutToMatrix4D(ret_c34m.m);}
      return ret;
   } /* </Matrix_csout> */ 

  public int GetProjection() {
    int ret = C4dApiPINVOKE.BaseView_GetProjection(swigCPtr);
    return ret;
  }

  public bool TestPoint(double x, double y) {
    bool ret = C4dApiPINVOKE.BaseView_TestPoint(swigCPtr, x, y);
    return ret;
  }

  public bool TestPointZ(Fusee.Math.Core.Vector3D /* constVector&_cstype */ p) {
    bool ret = C4dApiPINVOKE.BaseView_TestPointZ(swigCPtr, ref p /* constVector&_csin */);
    return ret;
  }

  public bool TestClipping3D(Fusee.Math.Core.Vector3D /* constVector&_cstype */ mp, Fusee.Math.Core.Vector3D /* constVector&_cstype */ rad, ref Fusee.Math.Core.Matrix4D /* constMatrix&_cstype */ mg, SWIGTYPE_p_Bool clip2d, SWIGTYPE_p_Bool clipz) {
    double[] adbl_mg;
    unsafe {adbl_mg = Fusee.Math.ArrayConversion.Convert.Matrix4DToArrayDoubleC4DLayout(mg);    fixed (double *pdbl_mg = adbl_mg) {
    /* constMatrix&_csin_pre */
    try {
      bool ret = C4dApiPINVOKE.BaseView_TestClipping3D(swigCPtr, ref mp /* constVector&_csin */, ref rad /* constVector&_csin */, (IntPtr) pdbl_mg /* constMatrix&_csin */, SWIGTYPE_p_Bool.getCPtr(clip2d), SWIGTYPE_p_Bool.getCPtr(clipz));
      return ret;
    } finally {
        // NOP mg = Fusee.Math.ArrayConversion.Convert.ArrayDoubleC4DLayoutToMatrix4D(pdbl_mg);
        /* constMatrix&_csin_post */
    }
} } /* constMatrix&_csin_terminator */
  }

  public bool ClipLine2D(ref Fusee.Math.Core.Vector3D /* Vector*&_cstype */ p1, ref Fusee.Math.Core.Vector3D /* Vector*&_cstype */ p2) {
    bool ret = C4dApiPINVOKE.BaseView_ClipLine2D(swigCPtr, ref p1 /* Vector*&_csin */, ref p2 /* Vector*&_csin */);
    return ret;
  }

  public bool ClipLineZ(ref Fusee.Math.Core.Vector3D /* Vector*&_cstype */ p1, ref Fusee.Math.Core.Vector3D /* Vector*&_cstype */ p2) {
    bool ret = C4dApiPINVOKE.BaseView_ClipLineZ(swigCPtr, ref p1 /* Vector*&_csin */, ref p2 /* Vector*&_csin */);
    return ret;
  }

  public Fusee.Math.Core.Vector3D /* Vector_cstype_out */ WS(Fusee.Math.Core.Vector3D /* constVector&_cstype */ p)  {  /* <Vector_csout> */
      Fusee.Math.Core.Vector3D ret = C4dApiPINVOKE.BaseView_WS(swigCPtr, ref p /* constVector&_csin */);
      return ret;
   } /* <Vector_csout> */ 

  public Fusee.Math.Core.Vector3D /* Vector_cstype_out */ SW(Fusee.Math.Core.Vector3D /* constVector&_cstype */ p)  {  /* <Vector_csout> */
      Fusee.Math.Core.Vector3D ret = C4dApiPINVOKE.BaseView_SW(swigCPtr, ref p /* constVector&_csin */);
      return ret;
   } /* <Vector_csout> */ 

  public Fusee.Math.Core.Vector3D /* Vector_cstype_out */ SW_Reference(double x, double y, Fusee.Math.Core.Vector3D /* constVector&_cstype */ wp)  {  /* <Vector_csout> */
      Fusee.Math.Core.Vector3D ret = C4dApiPINVOKE.BaseView_SW_Reference(swigCPtr, x, y, ref wp /* constVector&_csin */);
      return ret;
   } /* <Vector_csout> */ 

  public Fusee.Math.Core.Vector3D /* Vector_cstype_out */ WC(Fusee.Math.Core.Vector3D /* constVector&_cstype */ p)  {  /* <Vector_csout> */
      Fusee.Math.Core.Vector3D ret = C4dApiPINVOKE.BaseView_WC(swigCPtr, ref p /* constVector&_csin */);
      return ret;
   } /* <Vector_csout> */ 

  public Fusee.Math.Core.Vector3D /* Vector_cstype_out */ CW(Fusee.Math.Core.Vector3D /* constVector&_cstype */ p)  {  /* <Vector_csout> */
      Fusee.Math.Core.Vector3D ret = C4dApiPINVOKE.BaseView_CW(swigCPtr, ref p /* constVector&_csin */);
      return ret;
   } /* <Vector_csout> */ 

  public Fusee.Math.Core.Vector3D /* Vector_cstype_out */ SC(Fusee.Math.Core.Vector3D /* constVector&_cstype */ p)  {  /* <Vector_csout> */
      Fusee.Math.Core.Vector3D ret = C4dApiPINVOKE.BaseView_SC(swigCPtr, ref p /* constVector&_csin */);
      return ret;
   } /* <Vector_csout> */ 

  public Fusee.Math.Core.Vector3D /* Vector_cstype_out */ CS(Fusee.Math.Core.Vector3D /* constVector&_cstype */ p, bool z_inverse)  {  /* <Vector_csout> */
      Fusee.Math.Core.Vector3D ret = C4dApiPINVOKE.BaseView_CS(swigCPtr, ref p /* constVector&_csin */, z_inverse);
      return ret;
   } /* <Vector_csout> */ 

  public Fusee.Math.Core.Vector3D /* Vector_cstype_out */ WC_V(Fusee.Math.Core.Vector3D /* constVector&_cstype */ v)  {  /* <Vector_csout> */
      Fusee.Math.Core.Vector3D ret = C4dApiPINVOKE.BaseView_WC_V(swigCPtr, ref v /* constVector&_csin */);
      return ret;
   } /* <Vector_csout> */ 

  public Fusee.Math.Core.Vector3D /* Vector_cstype_out */ CW_V(Fusee.Math.Core.Vector3D /* constVector&_cstype */ v)  {  /* <Vector_csout> */
      Fusee.Math.Core.Vector3D ret = C4dApiPINVOKE.BaseView_CW_V(swigCPtr, ref v /* constVector&_csin */);
      return ret;
   } /* <Vector_csout> */ 

  public bool BackfaceCulling(Fusee.Math.Core.Vector3D /* constVector&_cstype */ n, Fusee.Math.Core.Vector3D /* constVector&_cstype */ p) {
    bool ret = C4dApiPINVOKE.BaseView_BackfaceCulling(swigCPtr, ref n /* constVector&_csin */, ref p /* constVector&_csin */);
    return ret;
  }

  public bool ZSensitiveNear() {
    bool ret = C4dApiPINVOKE.BaseView_ZSensitiveNear(swigCPtr);
    return ret;
  }

  public double ZSensitiveNearClipping() {
    double ret = C4dApiPINVOKE.BaseView_ZSensitiveNearClipping(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_StereoCameraInfo GetStereoInfo() {
    IntPtr cPtr = C4dApiPINVOKE.BaseView_GetStereoInfo(swigCPtr);
    SWIGTYPE_p_StereoCameraInfo ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_StereoCameraInfo(cPtr, false);
    return ret;
  }

  public bool ZSensitiveFar() {
    bool ret = C4dApiPINVOKE.BaseView_ZSensitiveFar(swigCPtr);
    return ret;
  }

  public double ZSensitiveFarClipping() {
    double ret = C4dApiPINVOKE.BaseView_ZSensitiveFarClipping(swigCPtr);
    return ret;
  }

  public double PW_S(double z, bool horizontal) {
    double ret = C4dApiPINVOKE.BaseView_PW_S(swigCPtr, z, horizontal);
    return ret;
  }

  public double WP_S(double z, bool horizontal) {
    double ret = C4dApiPINVOKE.BaseView_WP_S(swigCPtr, z, horizontal);
    return ret;
  }

  public double PW_W(Fusee.Math.Core.Vector3D /* constVector&_cstype */ p, bool horizontal) {
    double ret = C4dApiPINVOKE.BaseView_PW_W(swigCPtr, ref p /* constVector&_csin */, horizontal);
    return ret;
  }

  public double WP_W(Fusee.Math.Core.Vector3D /* constVector&_cstype */ p, bool horizontal) {
    double ret = C4dApiPINVOKE.BaseView_WP_W(swigCPtr, ref p /* constVector&_csin */, horizontal);
    return ret;
  }

  public Fusee.Math.Core.Vector3D /* Vector_cstype_out */ ProjectPointOnLine(Fusee.Math.Core.Vector3D /* constVector&_cstype */ p, Fusee.Math.Core.Vector3D /* constVector&_cstype */ v, double mouse_x, double mouse_y, SWIGTYPE_p_Real offset, SWIGTYPE_p_LONG err)  {  /* <Vector_csout> */
      Fusee.Math.Core.Vector3D ret = C4dApiPINVOKE.BaseView_ProjectPointOnLine__SWIG_0(swigCPtr, ref p /* constVector&_csin */, ref v /* constVector&_csin */, mouse_x, mouse_y, SWIGTYPE_p_Real.getCPtr(offset), SWIGTYPE_p_LONG.getCPtr(err));
      return ret;
   } /* <Vector_csout> */ 

  public Fusee.Math.Core.Vector3D /* Vector_cstype_out */ ProjectPointOnLine(Fusee.Math.Core.Vector3D /* constVector&_cstype */ p, Fusee.Math.Core.Vector3D /* constVector&_cstype */ v, double mouse_x, double mouse_y, SWIGTYPE_p_Real offset)  {  /* <Vector_csout> */
      Fusee.Math.Core.Vector3D ret = C4dApiPINVOKE.BaseView_ProjectPointOnLine__SWIG_1(swigCPtr, ref p /* constVector&_csin */, ref v /* constVector&_csin */, mouse_x, mouse_y, SWIGTYPE_p_Real.getCPtr(offset));
      return ret;
   } /* <Vector_csout> */ 

  public Fusee.Math.Core.Vector3D /* Vector_cstype_out */ ProjectPointOnLine(Fusee.Math.Core.Vector3D /* constVector&_cstype */ p, Fusee.Math.Core.Vector3D /* constVector&_cstype */ v, double mouse_x, double mouse_y)  {  /* <Vector_csout> */
      Fusee.Math.Core.Vector3D ret = C4dApiPINVOKE.BaseView_ProjectPointOnLine__SWIG_2(swigCPtr, ref p /* constVector&_csin */, ref v /* constVector&_csin */, mouse_x, mouse_y);
      return ret;
   } /* <Vector_csout> */ 

  public Fusee.Math.Core.Vector3D /* Vector_cstype_out */ ProjectPointOnPlane(Fusee.Math.Core.Vector3D /* constVector&_cstype */ p, Fusee.Math.Core.Vector3D /* constVector&_cstype */ v, double mouse_x, double mouse_y, SWIGTYPE_p_LONG err)  {  /* <Vector_csout> */
      Fusee.Math.Core.Vector3D ret = C4dApiPINVOKE.BaseView_ProjectPointOnPlane__SWIG_0(swigCPtr, ref p /* constVector&_csin */, ref v /* constVector&_csin */, mouse_x, mouse_y, SWIGTYPE_p_LONG.getCPtr(err));
      return ret;
   } /* <Vector_csout> */ 

  public Fusee.Math.Core.Vector3D /* Vector_cstype_out */ ProjectPointOnPlane(Fusee.Math.Core.Vector3D /* constVector&_cstype */ p, Fusee.Math.Core.Vector3D /* constVector&_cstype */ v, double mouse_x, double mouse_y)  {  /* <Vector_csout> */
      Fusee.Math.Core.Vector3D ret = C4dApiPINVOKE.BaseView_ProjectPointOnPlane__SWIG_1(swigCPtr, ref p /* constVector&_csin */, ref v /* constVector&_csin */, mouse_x, mouse_y);
      return ret;
   } /* <Vector_csout> */ 

}

}
