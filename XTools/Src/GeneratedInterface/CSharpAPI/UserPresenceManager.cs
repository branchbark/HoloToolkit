/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace HoloToolkit.XTools {

public class UserPresenceManager : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UserPresenceManager(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UserPresenceManager obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UserPresenceManager() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          XToolsClientPINVOKE.delete_UserPresenceManager(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual void AddListener(UserPresenceManagerListener newListener) {
    XToolsClientPINVOKE.UserPresenceManager_AddListener(swigCPtr, UserPresenceManagerListener.getCPtr(newListener));
  }

  public virtual void RemoveListener(UserPresenceManagerListener oldListener) {
    XToolsClientPINVOKE.UserPresenceManager_RemoveListener(swigCPtr, UserPresenceManagerListener.getCPtr(oldListener));
  }

  public virtual bool GetMuteState() {
    bool ret = XToolsClientPINVOKE.UserPresenceManager_GetMuteState(swigCPtr);
    return ret;
  }

  public virtual void SetMuteState(bool muteState) {
    XToolsClientPINVOKE.UserPresenceManager_SetMuteState(swigCPtr, muteState);
  }

  public virtual void SetName(XString name) {
    XToolsClientPINVOKE.UserPresenceManager_SetName(swigCPtr, XString.getCPtr(name));
  }

  public virtual XString GetName() {
    global::System.IntPtr cPtr = XToolsClientPINVOKE.UserPresenceManager_GetName(swigCPtr);
    XString ret = (cPtr == global::System.IntPtr.Zero) ? null : new XString(cPtr, true);
    return ret; 
  }

  public virtual void SetUser(User localUser) {
    XToolsClientPINVOKE.UserPresenceManager_SetUser(swigCPtr, User.getCPtr(localUser));
  }

}

}
