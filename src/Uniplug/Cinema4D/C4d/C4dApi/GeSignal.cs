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

public class GeSignal : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GeSignal(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(GeSignal obj) {
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

  public bool Init(SIGNALMODE mode) {
    bool ret = C4dApiPINVOKE.GeSignal_Init(swigCPtr, (int)mode);
    return ret;
  }

  public void Set() {
    C4dApiPINVOKE.GeSignal_Set(swigCPtr);
  }

  public void Clear() {
    C4dApiPINVOKE.GeSignal_Clear(swigCPtr);
  }

  public bool Wait(int timeout) {
    bool ret = C4dApiPINVOKE.GeSignal_Wait(swigCPtr, timeout);
    return ret;
  }

  public static GeSignal Alloc() {
    IntPtr cPtr = C4dApiPINVOKE.GeSignal_Alloc();
    GeSignal ret = (cPtr == IntPtr.Zero) ? null : new GeSignal(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_GeSignal sm) {
    C4dApiPINVOKE.GeSignal_Free(SWIGTYPE_p_p_GeSignal.getCPtr(sm));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
