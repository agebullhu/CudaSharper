#pragma once
#pragma comment(lib,"cublas.lib")
#include "cuda.h"
#include "cuda_runtime.h"
#include "cublas_v2.h"
#include "device_launch_parameters.h"
#include "cuda_profiler_api.h"
#include "device_functions.h"

#include "device_info.h"

namespace csl {
	cublasOperation_t cuda_blas_determine_op(int32_t op);

	cudaError_t cuda_blas_matrix_multiply(
		const int32_t device_id,
		const int32_t transa_op, const int32_t transb_op,
		const int32_t m, const int32_t n, const int32_t k,
		const float alpha,
		const float* __restrict a,
		const float* __restrict b,
		const float beta,
		float* __restrict c);
	cudaError_t cuda_blas_matrix_multiply(
		const int32_t device_id,
		const int32_t transa_op, const int32_t transb_op,
		const int32_t m, const int32_t n, const int32_t k,
		const double alpha,
		const double* __restrict a,
		const double* __restrict b,
		const double beta,
		double* __restrict c);
}
