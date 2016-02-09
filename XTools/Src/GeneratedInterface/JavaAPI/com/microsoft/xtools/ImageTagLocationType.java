/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.microsoft.xtools;

public enum ImageTagLocationType {
  TopLeft,
  TopRight,
  BottomLeft,
  BottomRight,
  Center;

  public final int swigValue() {
    return swigValue;
  }

  public static ImageTagLocationType swigToEnum(int swigValue) {
    ImageTagLocationType[] swigValues = ImageTagLocationType.class.getEnumConstants();
    if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
      return swigValues[swigValue];
    for (ImageTagLocationType swigEnum : swigValues)
      if (swigEnum.swigValue == swigValue)
        return swigEnum;
    throw new IllegalArgumentException("No enum " + ImageTagLocationType.class + " with value " + swigValue);
  }

  @SuppressWarnings("unused")
  private ImageTagLocationType() {
    this.swigValue = SwigNext.next++;
  }

  @SuppressWarnings("unused")
  private ImageTagLocationType(int swigValue) {
    this.swigValue = swigValue;
    SwigNext.next = swigValue+1;
  }

  @SuppressWarnings("unused")
  private ImageTagLocationType(ImageTagLocationType swigEnum) {
    this.swigValue = swigEnum.swigValue;
    SwigNext.next = this.swigValue+1;
  }

  private final int swigValue;

  private static class SwigNext {
    private static int next = 0;
  }
}

