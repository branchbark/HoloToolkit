/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.microsoft.xtools;

public enum ElementType {
  UnknownType(0),
  Int32Type,
  FloatType,
  StringType,
  ObjectType;

  public final int swigValue() {
    return swigValue;
  }

  public static ElementType swigToEnum(int swigValue) {
    ElementType[] swigValues = ElementType.class.getEnumConstants();
    if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
      return swigValues[swigValue];
    for (ElementType swigEnum : swigValues)
      if (swigEnum.swigValue == swigValue)
        return swigEnum;
    throw new IllegalArgumentException("No enum " + ElementType.class + " with value " + swigValue);
  }

  @SuppressWarnings("unused")
  private ElementType() {
    this.swigValue = SwigNext.next++;
  }

  @SuppressWarnings("unused")
  private ElementType(int swigValue) {
    this.swigValue = swigValue;
    SwigNext.next = swigValue+1;
  }

  @SuppressWarnings("unused")
  private ElementType(ElementType swigEnum) {
    this.swigValue = swigEnum.swigValue;
    SwigNext.next = this.swigValue+1;
  }

  private final int swigValue;

  private static class SwigNext {
    private static int next = 0;
  }
}

