//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace C4d {

public class ChannelData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ChannelData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChannelData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChannelData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_ChannelData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ChannelData() : this(C4dApiPINVOKE.new_ChannelData__SWIG_0(), true) {
  }

  public ChannelData(BaseVolumeData t_vd) : this(C4dApiPINVOKE.new_ChannelData__SWIG_1(BaseVolumeData.getCPtr(t_vd)), true) {
  }

  public Fusee.Math.Core.double3 /* Vector_cstype_out */ p {
    /* <Vector_csvarin> */
    set 
	{
      C4dApiPINVOKE.ChannelData_p_set(swigCPtr, value /* Vector_csin */);
    }  /* </Vector_csvarin> */   
   /* <Vector_csvarout> */
   get
   {  
      Fusee.Math.Core.double3 ret = C4dApiPINVOKE.ChannelData_p_get(swigCPtr);
      return ret;
   } /* <Vector_csvarout> */ 
  }

  public Fusee.Math.Core.double3 /* Vector_cstype_out */ n {
    /* <Vector_csvarin> */
    set 
	{
      C4dApiPINVOKE.ChannelData_n_set(swigCPtr, value /* Vector_csin */);
    }  /* </Vector_csvarin> */   
   /* <Vector_csvarout> */
   get
   {  
      Fusee.Math.Core.double3 ret = C4dApiPINVOKE.ChannelData_n_get(swigCPtr);
      return ret;
   } /* <Vector_csvarout> */ 
  }

  public Fusee.Math.Core.double3 /* Vector_cstype_out */ d {
    /* <Vector_csvarin> */
    set 
	{
      C4dApiPINVOKE.ChannelData_d_set(swigCPtr, value /* Vector_csin */);
    }  /* </Vector_csvarin> */   
   /* <Vector_csvarout> */
   get
   {  
      Fusee.Math.Core.double3 ret = C4dApiPINVOKE.ChannelData_d_get(swigCPtr);
      return ret;
   } /* <Vector_csvarout> */ 
  }

  public double t {
    set {
      C4dApiPINVOKE.ChannelData_t_set(swigCPtr, value);
    } 
    get {
      double ret = C4dApiPINVOKE.ChannelData_t_get(swigCPtr);
      return ret;
    } 
  }

  public int texflag {
    set {
      C4dApiPINVOKE.ChannelData_texflag_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.ChannelData_texflag_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_VolumeData vd {
    set {
      C4dApiPINVOKE.ChannelData_vd_set(swigCPtr, SWIGTYPE_p_VolumeData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.ChannelData_vd_get(swigCPtr);
      SWIGTYPE_p_VolumeData ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_VolumeData(cPtr, false);
      return ret;
    } 
  }

  public double off {
    set {
      C4dApiPINVOKE.ChannelData_off_set(swigCPtr, value);
    } 
    get {
      double ret = C4dApiPINVOKE.ChannelData_off_get(swigCPtr);
      return ret;
    } 
  }

  public double scale {
    set {
      C4dApiPINVOKE.ChannelData_scale_set(swigCPtr, value);
    } 
    get {
      double ret = C4dApiPINVOKE.ChannelData_scale_get(swigCPtr);
      return ret;
    } 
  }

  public int GetCurrentCPU() {
    int ret = C4dApiPINVOKE.ChannelData_GetCurrentCPU(swigCPtr);
    return ret;
  }

}

}
