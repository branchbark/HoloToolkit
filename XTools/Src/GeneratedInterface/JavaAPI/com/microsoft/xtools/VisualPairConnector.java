/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.microsoft.xtools;

public class VisualPairConnector extends PairMaker {
  private long swigCPtr;

  protected VisualPairConnector(long cPtr, boolean cMemoryOwn) {
    super(XToolsClientJNI.VisualPairConnector_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(VisualPairConnector obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        XToolsClientJNI.delete_VisualPairConnector(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public static VisualPairConnector Create() {
	// ref_ptr by value javaout
    long cPtr = XToolsClientJNI.VisualPairConnector_Create();
    return (cPtr == 0) ? null : new VisualPairConnector(cPtr, true);
  }

  public boolean ProcessImage(byte[] image, int width, int height, int bytesPerPixel) {
    return XToolsClientJNI.VisualPairConnector_ProcessImage(swigCPtr, this, image, width, height, bytesPerPixel);
  }

  public boolean IsProcessingImage() {
    return XToolsClientJNI.VisualPairConnector_IsProcessingImage(swigCPtr, this);
  }

}
