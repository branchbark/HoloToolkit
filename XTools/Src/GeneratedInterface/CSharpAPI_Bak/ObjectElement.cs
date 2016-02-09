/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace XTools {

public class ObjectElement : Element {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ObjectElement(global::System.IntPtr cPtr, bool cMemoryOwn) : base(XToolsClientPINVOKE.ObjectElement_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ObjectElement obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ObjectElement() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          XToolsClientPINVOKE.delete_ObjectElement(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static ObjectElement Cast(Element element) {
    global::System.IntPtr cPtr = XToolsClientPINVOKE.ObjectElement_Cast(Element.getCPtr(element));
    ObjectElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new ObjectElement(cPtr, true);
    return ret; 
  }

  public virtual IntElement CreateIntElement(XString name, int value) {
    global::System.IntPtr cPtr = XToolsClientPINVOKE.ObjectElement_CreateIntElement(swigCPtr, XString.getCPtr(name), value);
    IntElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new IntElement(cPtr, true);
    return ret; 
  }

  public virtual FloatElement CreateFloatElement(XString name, float value) {
    global::System.IntPtr cPtr = XToolsClientPINVOKE.ObjectElement_CreateFloatElement(swigCPtr, XString.getCPtr(name), value);
    FloatElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new FloatElement(cPtr, true);
    return ret; 
  }

  public virtual StringElement CreateStringElement(XString name, XString value) {
    global::System.IntPtr cPtr = XToolsClientPINVOKE.ObjectElement_CreateStringElement(swigCPtr, XString.getCPtr(name), XString.getCPtr(value));
    StringElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new StringElement(cPtr, true);
    return ret; 
  }

  public virtual ObjectElement CreateObjectElement(XString name, User owner) {
    global::System.IntPtr cPtr = XToolsClientPINVOKE.ObjectElement_CreateObjectElement__SWIG_0(swigCPtr, XString.getCPtr(name), User.getCPtr(owner));
    ObjectElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new ObjectElement(cPtr, true);
    return ret; 
  }

  public virtual ObjectElement CreateObjectElement(XString name) {
    global::System.IntPtr cPtr = XToolsClientPINVOKE.ObjectElement_CreateObjectElement__SWIG_1(swigCPtr, XString.getCPtr(name));
    ObjectElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new ObjectElement(cPtr, true);
    return ret; 
  }

  public virtual int GetElementCount() {
    int ret = XToolsClientPINVOKE.ObjectElement_GetElementCount(swigCPtr);
    return ret;
  }

  public virtual Element GetElement(long id) {
    global::System.IntPtr cPtr = XToolsClientPINVOKE.ObjectElement_GetElement__SWIG_0(swigCPtr, id);
    Element ret = (cPtr == global::System.IntPtr.Zero) ? null : new Element(cPtr, true);
    return ret; 
  }

  public virtual Element GetElement(XString name) {
    global::System.IntPtr cPtr = XToolsClientPINVOKE.ObjectElement_GetElement__SWIG_1(swigCPtr, XString.getCPtr(name));
    Element ret = (cPtr == global::System.IntPtr.Zero) ? null : new Element(cPtr, true);
    return ret; 
  }

  public virtual Element GetElementAt(int index) {
    global::System.IntPtr cPtr = XToolsClientPINVOKE.ObjectElement_GetElementAt(swigCPtr, index);
    Element ret = (cPtr == global::System.IntPtr.Zero) ? null : new Element(cPtr, true);
    return ret; 
  }

  public virtual void RemoveElement(Element element) {
    XToolsClientPINVOKE.ObjectElement_RemoveElement__SWIG_0(swigCPtr, Element.getCPtr(element));
  }

  public virtual void RemoveElement(long id) {
    XToolsClientPINVOKE.ObjectElement_RemoveElement__SWIG_1(swigCPtr, id);
  }

  public virtual void RemoveElementAt(int index) {
    XToolsClientPINVOKE.ObjectElement_RemoveElementAt(swigCPtr, index);
  }

  public virtual void AddListener(ObjectElementListener newListener) {
    XToolsClientPINVOKE.ObjectElement_AddListener(swigCPtr, ObjectElementListener.getCPtr(newListener));
  }

  public virtual void RemoveListener(ObjectElementListener oldListener) {
    XToolsClientPINVOKE.ObjectElement_RemoveListener(swigCPtr, ObjectElementListener.getCPtr(oldListener));
  }

  public virtual uint GetOwnerID() {
    uint ret = XToolsClientPINVOKE.ObjectElement_GetOwnerID(swigCPtr);
    return ret;
  }

}

}
