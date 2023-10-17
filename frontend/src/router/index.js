import { createRouter, createWebHistory } from "vue-router";
import Home from "../views/Home.vue";
import AddWorkout from "../views/AddWorkout.vue";
import Login from "../views/Login.vue";
import Register from "../views/Register.vue";
import ForgotPassword from "../views/ForgotPassword.vue";

const routes = [
	{
		path: "/",
		name: "home",
		component: Home,
	},
	{
		path: "/add-workout",
		name: "add-workout",
		component: AddWorkout,
	},
	{
		path: "/login",
		name: "login",
		component: Login,
	},
	{
		path: "/register",
		name: "register",
		component: Register,
	},
	{
		path: "/forgot-password",
		name: "fortgot-password",
		component: ForgotPassword,
	},
];
const router = createRouter({
	history: createWebHistory(),
	routes,
});

export default router;
