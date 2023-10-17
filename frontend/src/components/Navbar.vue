<template>
	<nav
		class="fixed top-0 left-0 right-0 z-20 font-bold text-black shadow-lg p-7 bg-gradient-to-r from-green-300 to-green-500"
	>
		<div class="container flex items-center justify-between mx-auto">
			<div class="flex items-center gap-1 mb-3 md:mb-0">
				<router-link to="/" class="flex items-center gap-2">
					<span class="text-2xl">Workout Buddy</span>
				</router-link>
			</div>
			<button class="block md:hidden" @click="toggleMenu">
				<i class="fa-solid fa-bars"></i>
			</button>
			<div class="hidden md:block">
				<ul class="flex space-x-4">
					<li v-for="item in navigationItems" :key="item.text">
						<router-link :to="item.to" @click="closeMenu">{{ item.text }}</router-link>
					</li>
					<li>
						<router-link
							class="p-3 text-white bg-black rounded-lg hover:bg-gray-700"
							to="/login"
						>
							Login
						</router-link>
					</li>
				</ul>
			</div>
		</div>
		<div v-if="collapseMenu">
			<ul class="flex flex-col gap-5">
				<li v-for="item in navigationItems" :key="item.text">
					<router-link :to="item.to" @click="closeMenu">{{ item.text }}</router-link>
				</li>
				<li>
					<router-link
						class="p-3 text-white bg-black rounded-lg hover:bg-gray-700"
						to="/login"
						@click="closeMenu"
					>
						Login
					</router-link>
				</li>
			</ul>
		</div>
	</nav>
</template>

<script setup>
import { ref } from "vue";
const collapseMenu = ref(false);

const navigationItems = [
	{ text: "Home", to: "/" },
	{ text: "Add Workout", to: "/add-workout" },
	// { text: "View Data", to: "/view-data" },
];

function toggleMenu() {
	collapseMenu.value = !collapseMenu.value;
}

function closeMenu() {
	collapseMenu.value = false;
}
</script>
