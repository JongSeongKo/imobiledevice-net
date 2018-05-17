//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="ScreenshotrClientHandle.cs" company="Quamotion">
// Copyright (c) 2016-2018 Quamotion. All rights reserved.
// </copyright>
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

namespace iMobileDevice.Screenshotr
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
#if !NETSTANDARD1_5
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, UnmanagedCode=true)]
#endif
#if !NETSTANDARD1_5
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, UnmanagedCode=true)]
#endif
    public partial class ScreenshotrClientHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
    {
        
        private string creationStackTrace;
        
        private ILibiMobileDevice api;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenshotrClientHandle"/> class.
        /// </summary>
        protected ScreenshotrClientHandle() : 
                base(true)
        {
            this.creationStackTrace = System.Environment.StackTrace;
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenshotrClientHandle"/> class, specifying whether the handle is to be reliably released.
        /// </summary>
        /// <param name="ownsHandle">
        /// <see langword="true"/> to reliably release the handle during the finalization phase; <see langword="false"/> to prevent reliable release (not recommended).
        /// </param>
        protected ScreenshotrClientHandle(bool ownsHandle) : 
                base(ownsHandle)
        {
            this.creationStackTrace = System.Environment.StackTrace;
        }
        
        /// <summary>
        /// Gets or sets the API to use
        /// </summary>
        public ILibiMobileDevice Api
        {
            get
            {
                return this.api;
            }
            set
            {
                this.api = value;
            }
        }
        
        /// <summary>
        /// Gets a value which represents a pointer or handle that has been initialized to zero.
        /// </summary>
        public static ScreenshotrClientHandle Zero
        {
            get
            {
                return ScreenshotrClientHandle.DangerousCreate(System.IntPtr.Zero);
            }
        }
        
        /// <inheritdoc/>
#if !NETSTANDARD1_5
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
#endif
        protected override bool ReleaseHandle()
        {
            System.Diagnostics.Debug.WriteLine("Releasing {0} {1} using {2}. This object was created at {3}", this.GetType().Name, this.handle, this.Api, this.creationStackTrace);
            return (this.Api.Screenshotr.screenshotr_client_free(this.handle) == ScreenshotrError.Success);
        }
        
        /// <summary>
        /// Creates a new <see cref="ScreenshotrClientHandle"/> from a <see cref="IntPtr"/>.
        /// </summary>
        /// <param name="unsafeHandle">
        /// The underlying <see cref="IntPtr"/>
        /// </param>
        /// <param name="ownsHandle">
        /// <see langword="true"/> to reliably release the handle during the finalization phase; <see langword="false"/> to prevent reliable release (not recommended).
        /// </param>
        /// <returns>
        /// </returns>
        public static ScreenshotrClientHandle DangerousCreate(System.IntPtr unsafeHandle, bool ownsHandle)
        {
            ScreenshotrClientHandle safeHandle;
            safeHandle = new ScreenshotrClientHandle(ownsHandle);
            safeHandle.SetHandle(unsafeHandle);
            return safeHandle;
        }
        
        /// <summary>
        /// Creates a new <see cref="ScreenshotrClientHandle"/> from a <see cref="IntPtr"/>.
        /// </summary>
        /// <param name="unsafeHandle">
        /// The underlying <see cref="IntPtr"/>
        /// </param>
        /// <returns>
        /// </returns>
        public static ScreenshotrClientHandle DangerousCreate(System.IntPtr unsafeHandle)
        {
            return ScreenshotrClientHandle.DangerousCreate(unsafeHandle, true);
        }
        
        /// <inheritdoc/>
        public override string ToString()
        {
            return string.Format("{0} ({1})", this.handle, "ScreenshotrClientHandle");
        }
        
        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (((obj != null) & (obj.GetType() == typeof(ScreenshotrClientHandle))))
            {
                return ((ScreenshotrClientHandle)obj).handle.Equals(this.handle);
            }
            else
            {
                return false;
            }
        }
        
        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.handle.GetHashCode();
        }
        
        /// <summary>
        /// Determines whether two specified instances of <see cref="ScreenshotrClientHandle"/> are equal.
        /// </summary>
        /// <param name="value1">
        /// The first pointer or handle to compare.
        /// </param>
        /// <param name="value2">
        /// The second pointer or handle to compare.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if <paramref name="value1"/> equals <paramref name="value2"/>; otherwise, <see langword="false"/>.
        /// </returns>
        public static bool operator == (ScreenshotrClientHandle value1, ScreenshotrClientHandle value2) 
        {
            if (object.Equals(value1, null) && object.Equals(value2, null))
            {
                return true;
            }
        
            if (object.Equals(value1, null) || object.Equals(value2, null))
            {
                return false;
            }
        
            return value1.handle == value2.handle;
        }
        
        /// <summary>
        /// Determines whether two specified instances of <see cref="ScreenshotrClientHandle"/> are not equal.
        /// </summary>
        /// <param name="value1">
        /// The first pointer or handle to compare.
        /// </param>
        /// <param name="value2">
        /// The second pointer or handle to compare.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if <paramref name="value1"/> does not equal <paramref name="value2"/>; otherwise, <see langword="false"/>.
        /// </returns>
        public static bool operator != (ScreenshotrClientHandle value1, ScreenshotrClientHandle value2) 
        {
            if (object.Equals(value1, null) && object.Equals(value2, null))
            {
                return false;
            }
        
            if (object.Equals(value1, null) || object.Equals(value2, null))
            {
                return true;
            }
        
            return value1.handle != value2.handle;
        }
    }
}
