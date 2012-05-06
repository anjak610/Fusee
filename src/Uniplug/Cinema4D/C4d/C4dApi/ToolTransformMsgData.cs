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

public class ToolTransformMsgData : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ToolTransformMsgData(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ToolTransformMsgData obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ToolTransformMsgData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_ToolTransformMsgData(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public double scl {
    set {
      C4dApiPINVOKE.ToolTransformMsgData_scl_set(swigCPtr, value);
    } 
    get {
      double ret = C4dApiPINVOKE.ToolTransformMsgData_scl_get(swigCPtr);
      return ret;
    } 
  }

  public Fusee.Math.Core.Matrix4D /* Matrix_cstype */ tm {
    /* <Matrix_csvarin> */
    set 
	{
       double[] adbl_value;
       unsafe 
	   {
		   adbl_value = Fusee.Math.ArrayConversion.Convert.Matrix4DToArrayDoubleC4DLayout(value);
           fixed (double *pdbl_value = adbl_value) 
		   {
              C4dApiPINVOKE.ToolTransformMsgData_tm_set(swigCPtr, (IntPtr) pdbl_value /*  Matrix_csin */);
		   }
	   }
    }  /* </Matrix_csvarin> */   
   /* <Matrix_csvarout> */
   get
   {  
      C34M ret_c34m = C4dApiPINVOKE.ToolTransformMsgData_tm_get(swigCPtr);
	  Fusee.Math.Core.Matrix4D ret;
	  unsafe {ret = Fusee.Math.ArrayConversion.Convert.ArrayDoubleC4DLayoutToMatrix4D(ret_c34m.m);}
      return ret;   
   } /* <Matrix_csvarout> */ 
  }

  public Fusee.Math.Core.Matrix4D /* Matrix_cstype */ mm {
    /* <Matrix_csvarin> */
    set 
	{
       double[] adbl_value;
       unsafe 
	   {
		   adbl_value = Fusee.Math.ArrayConversion.Convert.Matrix4DToArrayDoubleC4DLayout(value);
           fixed (double *pdbl_value = adbl_value) 
		   {
              C4dApiPINVOKE.ToolTransformMsgData_mm_set(swigCPtr, (IntPtr) pdbl_value /*  Matrix_csin */);
		   }
	   }
    }  /* </Matrix_csvarin> */   
   /* <Matrix_csvarout> */
   get
   {  
      C34M ret_c34m = C4dApiPINVOKE.ToolTransformMsgData_mm_get(swigCPtr);
	  Fusee.Math.Core.Matrix4D ret;
	  unsafe {ret = Fusee.Math.ArrayConversion.Convert.ArrayDoubleC4DLayoutToMatrix4D(ret_c34m.m);}
      return ret;   
   } /* <Matrix_csvarout> */ 
  }

  public Fusee.Math.Core.Matrix4D /* Matrix_cstype */ up {
    /* <Matrix_csvarin> */
    set 
	{
       double[] adbl_value;
       unsafe 
	   {
		   adbl_value = Fusee.Math.ArrayConversion.Convert.Matrix4DToArrayDoubleC4DLayout(value);
           fixed (double *pdbl_value = adbl_value) 
		   {
              C4dApiPINVOKE.ToolTransformMsgData_up_set(swigCPtr, (IntPtr) pdbl_value /*  Matrix_csin */);
		   }
	   }
    }  /* </Matrix_csvarin> */   
   /* <Matrix_csvarout> */
   get
   {  
      C34M ret_c34m = C4dApiPINVOKE.ToolTransformMsgData_up_get(swigCPtr);
	  Fusee.Math.Core.Matrix4D ret;
	  unsafe {ret = Fusee.Math.ArrayConversion.Convert.ArrayDoubleC4DLayoutToMatrix4D(ret_c34m.m);}
      return ret;   
   } /* <Matrix_csvarout> */ 
  }

  public bool children {
    set {
      C4dApiPINVOKE.ToolTransformMsgData_children_set(swigCPtr, value);
    } 
    get {
      bool ret = C4dApiPINVOKE.ToolTransformMsgData_children_get(swigCPtr);
      return ret;
    } 
  }

  public BaseObject undo {
    set {
      C4dApiPINVOKE.ToolTransformMsgData_undo_set(swigCPtr, BaseObject.getCPtr(value));
    } 
    get {
      IntPtr cPtr = C4dApiPINVOKE.ToolTransformMsgData_undo_get(swigCPtr);
      BaseObject ret = (cPtr == IntPtr.Zero) ? null : new BaseObject(cPtr, false);
      return ret;
    } 
  }

  public TOOLTRANSFORM_FLAG flags {
    set {
      C4dApiPINVOKE.ToolTransformMsgData_flags_set(swigCPtr, (int)value);
    } 
    get {
      TOOLTRANSFORM_FLAG ret = (TOOLTRANSFORM_FLAG)C4dApiPINVOKE.ToolTransformMsgData_flags_get(swigCPtr);
      return ret;
    } 
  }

  public ToolTransformMsgData() : this(C4dApiPINVOKE.new_ToolTransformMsgData(), true) {
  }

}

}
