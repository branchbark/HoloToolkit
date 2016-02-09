/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace XTools {

public class XToolsManager : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XToolsManager(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XToolsManager obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XToolsManager() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          XToolsClientPINVOKE.delete_XToolsManager(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static XToolsManager Create(ClientConfig config) {
    global::System.IntPtr cPtr = XToolsClientPINVOKE.XToolsManager_Create(ClientConfig.getCPtr(config));
    XToolsManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new XToolsManager(cPtr, true);
    return ret; 
  }

  public virtual SessionManager GetSessionManager() {
    global::System.IntPtr cPtr = XToolsClientPINVOKE.XToolsManager_GetSessionManager(swigCPtr);
    SessionManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new SessionManager(cPtr, true);
    return ret; 
  }

  public virtual UserPresenceManager GetUserPresenceManager() {
    global::System.IntPtr cPtr = XToolsClientPINVOKE.XToolsManager_GetUserPresenceManager(swigCPtr);
    UserPresenceManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new UserPresenceManager(cPtr, true);
    return ret; 
  }

  public virtual AudioManager GetAudioManager() {
    global::System.IntPtr cPtr = XToolsClientPINVOKE.XToolsManager_GetAudioManager(swigCPtr);
    AudioManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new AudioManager(cPtr, true);
    return ret; 
  }

  public virtual PairingManager GetPairingManager() {
    global::System.IntPtr cPtr = XToolsClientPINVOKE.XToolsManager_GetPairingManager(swigCPtr);
    PairingManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new PairingManager(cPtr, true);
    return ret; 
  }

  public virtual ObjectElement GetRootSyncObject() {
    global::System.IntPtr cPtr = XToolsClientPINVOKE.XToolsManager_GetRootSyncObject(swigCPtr);
    ObjectElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new ObjectElement(cPtr, true);
    return ret; 
  }

  public virtual bool RegisterSyncListener(SyncListener listener) {
    bool ret = XToolsClientPINVOKE.XToolsManager_RegisterSyncListener(swigCPtr, SyncListener.getCPtr(listener));
    return ret;
  }

  public virtual void Update() {
    XToolsClientPINVOKE.XToolsManager_Update(swigCPtr);
  }

  public virtual NetworkConnection GetPairedConnection() {
    global::System.IntPtr cPtr = XToolsClientPINVOKE.XToolsManager_GetPairedConnection(swigCPtr);
    NetworkConnection ret = (cPtr == global::System.IntPtr.Zero) ? null : new NetworkConnection(cPtr, true);
    return ret; 
  }

  public virtual NetworkConnection GetServerConnection() {
    global::System.IntPtr cPtr = XToolsClientPINVOKE.XToolsManager_GetServerConnection(swigCPtr);
    NetworkConnection ret = (cPtr == global::System.IntPtr.Zero) ? null : new NetworkConnection(cPtr, true);
    return ret; 
  }

  public virtual Settings GetSettings() {
    global::System.IntPtr cPtr = XToolsClientPINVOKE.XToolsManager_GetSettings(swigCPtr);
    Settings ret = (cPtr == global::System.IntPtr.Zero) ? null : new Settings(cPtr, true);
    return ret; 
  }

  public virtual void SetServerConnectionInfo(XString address, uint port) {
    XToolsClientPINVOKE.XToolsManager_SetServerConnectionInfo(swigCPtr, XString.getCPtr(address), port);
  }

  public virtual User GetLocalUser() {
    global::System.IntPtr cPtr = XToolsClientPINVOKE.XToolsManager_GetLocalUser(swigCPtr);
    User ret = (cPtr == global::System.IntPtr.Zero) ? null : new User(cPtr, true);
    return ret; 
  }

  public virtual void SetUserName(XString name) {
    XToolsClientPINVOKE.XToolsManager_SetUserName(swigCPtr, XString.getCPtr(name));
  }

}

}
