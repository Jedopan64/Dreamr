<template>
  <b-nav-item-dropdown v-if="isAuthenticated" right>
    <template slot="button-content">
      <i class="fas fa-user"></i>
      {{username}}
    </template>
    <b-dropdown-item to="/profile">
      <i class="fas fa-user"></i>
      My Account
    </b-dropdown-item>
    <b-dropdown-item @click="addGoal">
      <i class="fas fa-user"></i>
      Add Goal
    </b-dropdown-item>
    <b-dropdown-item @click="logout">
      <i class="fas fa-sign-out-alt"></i>
      Logout
    </b-dropdown-item>
  </b-nav-item-dropdown>
  <b-nav-item v-else @click="login">
    <i class="fas fa-user"></i>
    Login / register
  </b-nav-item>
</template>

<script>
export default {
  name: "auth-nav-item",
  computed: {
    isAuthenticated() {
      return this.$store.getters.isAuthenticated;
    },
    username(){
      return `${this.$store.state.auth.email}`;
    }
  },
  methods: {
    login() {
      this.$store.commit("showAuthModal");
    },
    logout() {
      this.$store.dispatch("logout").then(() => {
        if (this.$route.meta.requiresAuth) {
          this.$router.push("/");
        }
      });
    },
    addGoal(){
      this.$store.commit("showAddGoalForm");
    }
  }
};
</script>
