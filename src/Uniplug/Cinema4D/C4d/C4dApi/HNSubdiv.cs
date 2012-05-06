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

public class HNSubdiv : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal HNSubdiv(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(HNSubdiv obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~HNSubdiv() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_HNSubdiv(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public PolygonObject op {
    set {
      C4dApiPINVOKE.HNSubdiv_op_set(swigCPtr, PolygonObject.getCPtr(value));
    } 
    get {
      IntPtr cPtr = C4dApiPINVOKE.HNSubdiv_op_get(swigCPtr);
      PolygonObject ret = (cPtr == IntPtr.Zero) ? null : new PolygonObject(cPtr, false);
      return ret;
    } 
  }

  public double lod {
    set {
      C4dApiPINVOKE.HNSubdiv_lod_set(swigCPtr, value);
    } 
    get {
      double ret = C4dApiPINVOKE.HNSubdiv_lod_get(swigCPtr);
      return ret;
    } 
  }

  public int subdiv {
    set {
      C4dApiPINVOKE.HNSubdiv_subdiv_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.HNSubdiv_subdiv_get(swigCPtr);
      return ret;
    } 
  }

  public HNSubdiv() : this(C4dApiPINVOKE.new_HNSubdiv(), true) {
  }

}

}
