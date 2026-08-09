// Debug: Vérifier que le script est chargé
console.log('[Password Toggle] Script loaded');

document.addEventListener('DOMContentLoaded', () => {

    const toggleButton = document.getElementById('togglePassword');
    const passwordInput = document.getElementById('Password');
    const eyeOpen = document.getElementById('eyeOpen');
    const eyeClosed = document.getElementById('eyeClosed');

    if (!toggleButton || !passwordInput || !eyeOpen || !eyeClosed) {
        console.error('[Password Toggle] Missing elements, aborting initialization');
        return;
    }

    toggleButton.addEventListener('click', () => {
        console.log('[Password Toggle] Click event fired');
        const isPassword = passwordInput.type === 'password';

        passwordInput.type = isPassword ? 'text' : 'password';

        eyeOpen.classList.toggle('hidden', !isPassword);
        eyeClosed.classList.toggle('hidden', isPassword);
    });
});