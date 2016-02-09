/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.microsoft.xtools;

public class XToolsManager {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected XToolsManager(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(XToolsManager obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        XToolsClientJNI.delete_XToolsManager(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public static XToolsManager Create(ClientConfig config) {
	// ref_ptr by value javaout
    long cPtr = XToolsClientJNI.XToolsManager_Create(ClientConfig.getCPtr(config), config);
    return (cPtr == 0) ? null : new XToolsManager(cPtr, true);
  }

  public SessionManager GetSessionManager() {
	// ref_ptr by reference javaout
    long cPtr = XToolsClientJNI.XToolsManager_GetSessionManager(swigCPtr, this);
    return (cPtr == 0) ? null : new SessionManager(cPtr, true);
  }

  public UserPresenceManager GetUserPresenceManager() {
	// ref_ptr by reference javaout
    long cPtr = XToolsClientJNI.XToolsManager_GetUserPresenceManager(swigCPtr, this);
    return (cPtr == 0) ? null : new UserPresenceManager(cPtr, true);
  }

  public AudioManager GetAudioManager() {
	// ref_ptr by reference javaout
    long cPtr = XToolsClientJNI.XToolsManager_GetAudioManager(swigCPtr, this);
    return (cPtr == 0) ? null : new AudioManager(cPtr, true);
  }

  public PairingManager GetPairingManager() {
	// ref_ptr by reference javaout
    long cPtr = XToolsClientJNI.XToolsManager_GetPairingManager(swigCPtr, this);
    return (cPtr == 0) ? null : new PairingManager(cPtr, true);
  }

  public ObjectElement GetRootSyncObject() {
	// ref_ptr by value javaout
    long cPtr = XToolsClientJNI.XToolsManager_GetRootSyncObject(swigCPtr, this);
    return (cPtr == 0) ? null : new ObjectElement(cPtr, true);
  }

  public boolean RegisterSyncListener(SyncListener listener) {
    return XToolsClientJNI.XToolsManager_RegisterSyncListener(swigCPtr, this, SyncListener.getCPtr(listener), listener);
  }

  public void Update() {
    XToolsClientJNI.XToolsManager_Update(swigCPtr, this);
  }

  public NetworkConnection GetPairedConnection() {
	// ref_ptr by value javaout
    long cPtr = XToolsClientJNI.XToolsManager_GetPairedConnection(swigCPtr, this);
    return (cPtr == 0) ? null : new NetworkConnection(cPtr, true);
  }

  public NetworkConnection GetServerConnection() {
	// ref_ptr by value javaout
    long cPtr = XToolsClientJNI.XToolsManager_GetServerConnection(swigCPtr, this);
    return (cPtr == 0) ? null : new NetworkConnection(cPtr, true);
  }

  public Settings GetSettings() {
	// ref_ptr by reference javaout
    long cPtr = XToolsClientJNI.XToolsManager_GetSettings(swigCPtr, this);
    return (cPtr == 0) ? null : new Settings(cPtr, true);
  }

  public void SetServerConnectionInfo(XString address, long port) {
    XToolsClientJNI.XToolsManager_SetServerConnectionInfo(swigCPtr, this, XString.getCPtr(address), address, port);
  }

  public User GetLocalUser() {
	// ref_ptr by value javaout
    long cPtr = XToolsClientJNI.XToolsManager_GetLocalUser(swigCPtr, this);
    return (cPtr == 0) ? null : new User(cPtr, true);
  }

  public void SetUserName(XString name) {
    XToolsClientJNI.XToolsManager_SetUserName(swigCPtr, this, XString.getCPtr(name), name);
  }

}
