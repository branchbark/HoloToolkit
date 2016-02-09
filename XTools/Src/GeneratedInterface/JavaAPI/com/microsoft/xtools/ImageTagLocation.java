/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.microsoft.xtools;

public class ImageTagLocation {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected ImageTagLocation(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(ImageTagLocation obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        XToolsClientJNI.delete_ImageTagLocation(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public int GetTagId() {
    return XToolsClientJNI.ImageTagLocation_GetTagId(swigCPtr, this);
  }

  public float GetPixelX(ImageTagLocationType locationType) {
    return XToolsClientJNI.ImageTagLocation_GetPixelX(swigCPtr, this, locationType.swigValue());
  }

  public float GetPixelY(ImageTagLocationType locationType) {
    return XToolsClientJNI.ImageTagLocation_GetPixelY(swigCPtr, this, locationType.swigValue());
  }

  public float GetModelViewMatrix(int row, int col, float F, float G, float A, float B, float C, float D) {
    return XToolsClientJNI.ImageTagLocation_GetModelViewMatrix(swigCPtr, this, row, col, F, G, A, B, C, D);
  }

}
