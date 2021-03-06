﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiaNet.Backend.TensorSharp.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SiaNet.Backend.TensorSharp.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // Compute the offsets into the given tensors for a linear index. For the &apos;t2&apos;
        ///// tensor, dimension &apos;dim&apos; is skipped. The tensors are assumed to have the same
        ///// size (with the exception of &apos;t2&apos; in dimension &apos;dim&apos;).
        ///// This version uses a static number of dimensions.
        ///template &lt;typename IndexType, int Dims&gt;
        ///struct IndexToScatterGatherOffsets {
        ///	static __device__ void compute(
        ///		IndexType linearId, const int dim,
        ///		const TensorInfo&lt;IndexType&gt;&amp; index, IndexType* indexOffset,
        ///		const TensorInfo&lt;IndexTy [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GatherScatter {
            get {
                return ResourceManager.GetString("GatherScatter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #define CUDA_KERNEL_LOOP(i, n) \
        ///  for (int i = blockIdx.x * blockDim.x + threadIdx.x; i &lt; (n); i += blockDim.x * gridDim.x)
        ///
        ///// (borrowed from Caffe: https://github.com/BVLC/caffe/blob/master/src/caffe/layers/conv_layer.cu)
        ///template &lt;typename Dtype&gt;
        ///__device__ void im2col_kernel_t(const int n, const Dtype* data_im,
        ///	const int height, const int width, const int channels,
        ///	const int ksize_h, const int ksize_w,
        ///	const int pad_h, const int pad_w,
        ///	const int stride_h, const int stride_w,
        ///	const int di [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Im2Col {
            get {
                return ResourceManager.GetString("Im2Col", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // We prefer this kernel to avoid reloading index points if the number
        ///// of indices is a small number.
        ///// This kernel in fact works for all choices of problem size, but if
        ///// the number of indices chosen is large, then the
        ///// indexSelectLargeIndex kernel is a better choice to increase
        ///// parallelism.
        ///template &lt;typename IndexType, int DstDim, int SrcDim, int IdxDim&gt;
        ///__device__ void indexSelectSmallIndex(TensorInfo&lt;IndexType&gt; dst,
        ///	TensorInfo&lt;IndexType&gt; src,
        ///	TensorInfo&lt;IndexType&gt; indices,
        ///	int dst [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string IndexSelect {
            get {
                return ResourceManager.GetString("IndexSelect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // Compute the offsets into the given tensors for a linear index. For the &apos;t2&apos;
        ///// tensor, dimension &apos;dim&apos; is skipped. The tensors are assumed to have the same
        ///// size (with the exception of &apos;t2&apos; in dimension &apos;dim&apos;).
        ///// This version uses a static number of dimensions.
        ///// Same as above but using a dynamic number of dimensions.
        ///template &lt;typename IndexType&gt;
        ///struct DiagOffsets&lt;IndexType, -1&gt; {
        ///	static __device__ void compute(
        ///		IndexType linearId, const int dim, const TensorInfo&lt;IndexType&gt;&amp; t, IndexType [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MatrixOps {
            get {
                return ResourceManager.GetString("MatrixOps", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #define CUDA_KERNEL_LOOP(i, n) \
        ///  for (int i = blockIdx.x * blockDim.x + threadIdx.x; i &lt; (n); i += blockDim.x * gridDim.x)
        ///
        ///// kernels borrowed from Caffe
        ///template &lt;typename Dtype&gt;
        ///__global__ void MaxPoolForward_t(const int nthreads, const Dtype* bottom_data,
        ///	const int num, const int channels, const int height,
        ///	const int width, const int pooled_height, const int pooled_width,
        ///	const int kernel_h, const int kernel_w, const int stride_h,
        ///	const int stride_w, const int pad_h, const int pad_w, Dtyp [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SpatialMaxPool {
            get {
                return ResourceManager.GetString("SpatialMaxPool", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // Given the sum of values and the sum of squares, compute the variance or standard deviation.
        ///template&lt;bool flag, bool apply_sqrt&gt;
        ///__forceinline__ __device__ float computeVar(float sum, float sum2, unsigned row_size)
        ///{
        ///	if (flag)
        ///	{
        ///		sum /= row_size;
        ///		sum2 /= row_size;
        ///		sum2 -= sum * sum;
        ///		sum2 = (sum2 &lt; 0 ? 0 : sum2);
        ///	}
        ///	else
        ///	{
        ///		sum /= row_size;
        ///		sum2 /= row_size - 1;
        ///		sum2 -= ((float)row_size) / ((float)(row_size - 1)) * sum * sum;
        ///		sum2 = (sum2 &lt; 0 ? 0 : sum2);
        ///	}
        ///	if (apply_ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string VarStd {
            get {
                return ResourceManager.GetString("VarStd", resourceCulture);
            }
        }
    }
}
