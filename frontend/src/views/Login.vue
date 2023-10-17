<template>
	<section class="px-10 py-16 mt-28">
		<h1 class="mb-10 text-4xl font-bold text-center">Login</h1>
		<div
			class="flex flex-col items-center justify-center py-10 mx-auto bg-gray-200 shadow-lg md:w-3/4 lg:w-1/4 rounded-xl"
		>
			<form method="post">
				<div class="flex flex-col mb-5">
					<label class="form-label" for="">Email</label>
					<input class="form-field" type="email" v-model="email" />
				</div>
				<div class="flex flex-col mb-5">
					<label class="form-label" for="">Password</label>
					<input class="form-field" type="password" v-model="password" />
				</div>
				<div class="flex justify-center">
					<button type="submit" class="btn">Send</button>
				</div>
			</form>
			<router-link class="mt-3 mb-3 login-link" to="/forgot-password">
				Forgot your password?
			</router-link>

			<router-link class="login-link" to="/register">
				Don't have an account? Create one here
			</router-link>
		</div>
	</section>
</template>

<script setup>
import { ref } from "vue";
const email = ref("");
const password = ref("");
</script>

<style scoped>
.form-label {
	@apply mb-2;
}
.form-field {
	@apply p-1 rounded focus:outline-none bg-gray-100 focus:ring-2 focus:ring-green-400 transition duration-300 ease-in-out transform cursor-pointer w-full;
}
.btn {
	@apply bg-black text-white py-2 shadow rounded hover:ring-green-400 hover:ring-4 hover:text-green-400 transition duration-500 ease-in-out transform px-5;
}
.login-link {
	@apply relative text-black;
}

.login-link:before {
	content: "";
	position: absolute;
	bottom: 0;
	left: 0;
	right: 0;
	height: 2px;
	background: transparent;
	transform: scaleX(0);
	transform-origin: 0 50%;
	transition: transform 0.3s ease-in-out;
}

.login-link:hover:before {
	background: #66bb6a;
	transform: scaleX(1);
}
</style>
